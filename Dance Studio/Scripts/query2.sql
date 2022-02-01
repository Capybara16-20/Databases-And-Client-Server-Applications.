select ФИО, [Дата рождения], Телефон
from Преподаватель JOIN Занятие ON Преподаватель.ID = Занятие.Преподаватель
group by ФИО, [Дата рождения], Телефон
having count(*) = (select max(a)
           from (
            select COUNT(Преподаватель) as a
            FROM Занятие
			GROUP BY Преподаватель)b)