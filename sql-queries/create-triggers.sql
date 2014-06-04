CREATE TRIGGER on_delete_person ON T_Persons INSTEAD OF DELETE
AS
  BEGIN
    IF EXISTS (
        SELECT 1
        FROM T_Accounts AS A, deleted AS D
        WHERE A.p_account_id = D.f_account_id
          AND A.balance < '0.0')
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

        DELETE FROM T_Address
        FROM T_Address AS A, deleted as D
        WHERE A.p_address_id = D.f_address_id;

        DELETE FROM T_Accounts
        FROM T_Accounts AS A, deleted as D
        WHERE A.p_account_id = D.f_account_id;
      END
  END
GO