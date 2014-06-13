CREATE TRIGGER on_delete_person ON T_Persons INSTEAD OF DELETE
AS
  BEGIN
    IF EXISTS (
        SELECT 1
        FROM T_Accounts AS A, deleted AS D
        WHERE A.p_account_id = D.f_account_id
          AND A.balance < '0.00')
      BEGIN
        RAISERROR('Das Konto der Person ist nicht ausgeglichen. Löschen nicht möglich.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
      END
    ELSE
      BEGIN
        DELETE FROM T_Persons
        FROM T_Persons AS P, deleted as D
        WHERE P.p_person_id = D.p_person_id;

        DELETE FROM T_Addresses
        FROM T_Addresses AS A, deleted as D
        WHERE A.p_address_id = D.f_address_id;

        DELETE FROM T_Accounts
        FROM T_Accounts AS A, deleted as D
        WHERE A.p_account_id = D.f_account_id;
      END
  END
GO

CREATE TRIGGER on_lend_book ON T_Borrowed INSTEAD OF INSERT
AS
  BEGIN
    IF (
      SELECT card_status
      FROM T_IdentityCards AS c
        RIGHT JOIN T_Persons AS p
          ON c.p_identity_number = p.f_identity_number
        RIGHT JOIN inserted AS i
          ON p.p_person_id = i.f_person_id
    ) = 'Abgelaufen'
      BEGIN
        RAISERROR('Der Ausweis des Benutzers ist abgelaufen.', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
      END
    ELSE
      BEGIN
        INSERT INTO T_Borrowed (p_f_signature, p_f_book_id, f_person_id, borrow_date, renewed)
        SELECT p_f_signature, p_f_book_id, f_person_id, borrow_date, renewed
        FROM inserted;
      END
  END
GO