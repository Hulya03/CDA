/*1. Afficher la liste des managers des départements 20 et 30*/

SELECT 
	ename,
	deptno, 
	job
FROM emp 
WHERE job LIKE 'MANAGER' AND ( deptno = 20 OR deptno = 30)
;

/*2. Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81 */

SELECT 
	ename,
	job,
	hiredate
FROM emp
WHERE job <> 'MANAGER' AND YEAR(hiredate) = 1981
;

/*3. Afficher la liste des employés ayant une commission*/

SELECT
	ename,
	comm
FROM emp
WHERE comm IS NOT NULL AND comm <> 0
;

/*4. Afficher la liste des noms, numéros de département, jobs et date d'embauche triés par Numero de Département et JOB les derniers embauches d'abord.*/

SELECT 
	ename,
	deptno,
	job,
	hiredate
FROM emp
ORDER BY deptno, hiredate DESC
;

/*5. Afficher la liste des employés travaillant à DALLAS*/

SELECT 
	ename, 
	job,
	loc
FROM emp
INNER JOIN dept ON emp.DEPTNO = dept.deptno
WHERE loc LIKE 'DALLAS'
;

/*6. Afficher les noms et dates d'embauche des employés embauchés avant leur manager, avec le nom et date d'embauche du manager.*/

SELECT 
	employe.ename AS nom_employe,
	employe.hiredate AS embauche_employe,
	manager.ENAME AS nom_manager,
	manager.HIREDATE AS embauche_manager
FROM emp employe
JOIN emp manager ON employe.mgr = manager.empno
WHERE employe.HIREDATE < manager.HIREDATE
;


/*7. Lister les numéros des employés n'ayant pas de subordonné.*/

SELECT
	employe.empno,
	employe.ename
FROM emp employe
LEFT JOIN emp manager ON employe.EMPNO = manager.mgr
WHERE manager.empno IS NULL 
;


/*8. Afficher les noms et dates d'embauche des employés embauchés avant BLAKE.*/

SELECT 
	ename,
	hiredate
FROM emp 
WHERE hiredate < (
	SELECT hiredate 
	FROM emp
	WHERE ename LIKE 'BLAKE'
	)
;

/*9. Afficher les employés embauchés le même jour que FORD.*/

SELECT 
	ename,
	hiredate
FROM emp 
WHERE hiredate = (
	SELECT hiredate 
	FROM emp
	WHERE ename LIKE 'FORD'
	) 
	AND ENAME <> 'FORD'
;

/*10. Lister les employés ayant le même manager que CLARK.*/

SELECT 
	ename,
	mgr
FROM emp
WHERE mgr = (
	SELECT mgr 
	FROM emp
	WHERE ename LIKE 'CLARK'
	)
;

/*11. Lister les employés ayant même job et même manager que TURNER.*/

SELECT 
	ename,
	job,
	mgr
FROM emp
WHERE job = (
	SELECT job 
	FROM emp
	WHERE ename = 'TURNER') 
	AND 
	mgr = (
	SELECT mgr 
	FROM emp
	WHERE ename = 'TURNER') 
;


/*12. Lister les employés du département RESEARCH embauchés le même jour que quelqu'un du département SALES.*/
/*= lister toutes les dates d'embauche du département sales
	 et dedans (=IN) prendre la date pour laquelle il existe un dname='RESEARCH' */

SELECT 
	ename,
	hiredate,
	dname
FROM emp
INNER JOIN dept ON emp.deptno = dept.DEPTNO
WHERE hiredate IN (SELECT hiredate FROM emp INNER JOIN dept ON emp.deptno = dept.DEPTNO WHERE dname LIKE 'SALES') AND dname = 'RESEARCH'
;

/*13. Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date d'embauche.*/

SELECT 
	ename,
	DATE_FORMAT(hiredate, "%a")
FROM emp
;

/*14. Donner, pour chaque employé, le nombre de mois qui s'est écoulé entre leur date d'embauche et la date actuelle.*/

/*The TIMESTAMPDIFF() function returns the difference between two datetime expressions in years, months, days, hours, minutes, or seconds.
Here’s the syntax of the TIMESTAMPDIFF function:

TIMESTAMPDIFF(unit, begin, end); */


SELECT 
	ename,
	TIMESTAMPDIFF(MONTH , hiredate, NOW())
FROM emp
;


/*15. Afficher la liste des employés ayant un M et un A dans leur nom.*/

SELECT
	ename
FROM emp
WHERE ename LIKE "%a%" AND ename LIKE "%m%"
;
