﻿
UPDATE Books
set Active=0
where Id =(SELECT Id FROM Books where Active=1 ORDER BY Id DESC
OFFSET 1  ROWS FETCH NEXT 1 ROWS ONLY)