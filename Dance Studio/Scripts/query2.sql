select ���, [���� ��������], �������
from ������������� JOIN ������� ON �������������.ID = �������.�������������
group by ���, [���� ��������], �������
having count(*) = (select max(a)
           from (
            select COUNT(�������������) as a
            FROM �������
			GROUP BY �������������)b)