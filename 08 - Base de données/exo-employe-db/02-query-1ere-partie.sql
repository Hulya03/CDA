/*1. Donner nom, job, numéro et salaire de tous les employés,puis seulement des employés du département 10 */

SELECT 
	ename,
	job, 
	empno,
	sal
FROM emp
;

SELECT 
	ename,
	job, 
	empno,
	sal
FROM emp
WHERE deptno = 10
;

/*2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800*/

SELECT 
	ename,
	job,
	sal
FROM emp
WHERE job = 'manager' AND sal > 2800
;

/*3. Donner la liste des MANAGER n'appartenant pas au département 30 */

SELECT 
	ename,
	deptno
FROM emp
WHERE job = 'manager' AND deptno <> 30
;


/*4. Liste des employés de salaire compris entre 1200 et 1400*/ 

SELECT
	ename,
	sal
FROM emp
WHERE sal BETWEEN '1200' AND '1400'
; 

/*5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique*/

SELECT 
	ename,
	deptno
FROM emp
WHERE deptno = 10 OR deptno = 30
ORDER BY ename ASC
;

/*6. Liste des employés du département 30 classés dans l'ordre des salaires croissants*/

SELECT 
	ename,
	deptno,
	sal
FROM emp
WHERE deptno = 30
ORDER BY sal ASC
;

/*7. Liste de tous les employés classés par emploi et salaires décroissants*/

SELECT
	ename,
	job,
	sal
FROM emp
ORDER BY job DESC, sal DESC 
;

/*8. Liste des différents emplois*/

SELECT
	job
FROM emp
GROUP BY job
;

/*9. Donner le nom du département où travaille ALLEN*/

SELECT 
	ename,
	dname
FROM emp
INNER JOIN dept ON emp.DEPTNO = dept.DEPTNO
WHERE ename = 'ALLEN'
;

/*10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants.*/

SELECT 
	dname,
	ename,
	job,
	sal
FROM emp
INNER JOIN dept ON emp.DEPTNO = dept.DEPTNO
ORDER BY dname DESC , sal DESC
; 

/*11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions*/

SELECT 
	ename,
	job,
	sal,
	comm,
	sal + IFNULL (comm,0)  
FROM emp
WHERE job = 'SALESMAN'
;    
      
/*12. Liste des employés du département 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997'*/
      
SELECT 
	ename,
	deptno,
	DATE_FORMAT(hiredate, "%a %d %c %Y") AS "mois d'embauche"
FROM emp
WHERE deptno = '20'
;     
      
/*13. Donner le salaire le plus élevé par département*/
      
SELECT 
	ename,
	deptno, 
	MAX(sal)
FROM emp
GROUP BY deptno
;     
      
/*14. Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi.*/
      
SELECT 
	deptno,
	job,
	SUM(sal + IFNULL (comm,0)),
	COUNT(empno),
	ROUND(AVG(sal),2)
FROM emp
GROUP BY deptno, job
;     
      
/*15. Même question mais on se limite aux sous-ensembles d'au moins 2 employés*/
      
SELECT 
	deptno,
	job,
	SUM(sal + IFNULL (comm,0)),
	COUNT(empno),
	ROUND(AVG(sal),2)
FROM emp
GROUP BY deptno, job
HAVING COUNT(empno) > 1 
;     
      
/*16. Liste des employés (Nom, département, salaire) de même emploi que JONES*/
      
SELECT 
	ename,
	deptno,
	sal
FROM emp 
WHERE job = (
	SELECT job
	FROM emp
	WHERE ename = 'JONES'
)     
;     
      
/*17. Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires*/
      
SELECT 
	ename, 
	sal
FROM emp
WHERE sal > ( 
	SELECT AVG(sal)
	FROM emp
)     
;     
      
/*18. Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet(5 caractères), budget. Entrez les valeurs suivantes:
	101ALPHA, 96000
	102BETA, 82000
	103GAMMA, 15000 */
	   
CREATE TABLE projet (
	project_num INT(3),
	project_name VARCHAR(5),
	budget DECIMAL(9,2),
	CONSTRAINT PK_project_num PRIMARY KEY (project_num)
);    
      
INSERT INTO projet 
(project_num, project_name, budget)
VALUES 
(101, 'ALPHA', 96000),
(102, 'BETA', 82000),
(103, 'GAMMA', 15000);
      
      
/*suprimer base de données*/
DROP TABLE projet ;
      
      
/*19. Ajouter l'attribut numéro de projet à la table EMP et affecter tous les vendeurs du département 30 au projet 101, et les autres au projet 102 */
      
ALTER TABLE emp 
	ADD project_num INT(3);
      
UPDATE emp SET project_num = 101 WHERE job = 'SALESMAN' AND deptno = 30;
UPDATE emp SET project_num = 102 WHERE job NOT LIKE 'SALESMAN' OR deptno <> 30;
      
      
/*20. Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet */
      
SELECT 
	ename,
	job
	dname,
	project_name
FROM emp
INNER JOIN dept ON emp.deptno = dept.deptno 
INNER JOIN projet ON emp.project_num = projet.project_num
;     
      
/*21. A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département et nom de projet triés sur nom de département et nom de projet*/
      
SELECT 
	ename,
	job
	dname,
	project_name
FROM emp
INNER JOIN dept ON emp.deptno = dept.deptno 
INNER JOIN projet ON emp.project_num = projet.project_num
ORDER BY dname, project_name;
      
      
/*22. Donner le nom du projet associé à chaque manager*/
      
SELECT 
	ename,
	job,
	project_name
FROM emp
INNER JOIN dept ON emp.deptno = dept.deptno
INNER JOIN projet ON emp.project_num = projet.project_num
WHERE job LIKE 'MANAGER'
;