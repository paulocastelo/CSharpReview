﻿/* 
   This doc will contain all the scripts that will be used in the project
*/


-- SELECT ALL THE PRODUCTS

SELECT *
FROM PRODUCTS, CATEGORY
WHERE
PRODUCTS.CATEGORY_ID = CATEGORY.CATEGORY_ID

-- USING JOIN

SELECT *
FROM PRODUCTS p
INNER JOIN CATEGORY cat
ON p.CATEGORY_ID = cat.CATEGORY_ID

-- SELECT ALL THE PRODUCTS WITH CATEGORY NAME
SELECT *
FROM PRODUCTS p
INNER JOIN CATEGORY cat
ON p.CATEGORY_ID = cat.CATEGORY_ID
WHERE cat.CATEGORY_NAME = 'Computers'

-- SELECT ALL THE PRODUCTS WITH CATEGORY NAME
SELECT p.*, cat.CATEGORY_NAME
FROM PRODUCTS p
INNER JOIN CATEGORY cat
	ON p.CATEGORY_ID = cat.CATEGORY_ID
WHERE cat.CATEGORY_NAME = 'Computers'
