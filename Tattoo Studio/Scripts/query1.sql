SELECT ���, �������������, [���� ��������], �����, �������, ����
FROM ������ JOIN [������ �� ����� ����������] ON ������.ID = [������ �� ����� ����������].������
WHERE ���� = (SELECT MAX(����)
				FROM [������ �� ����� ����������]) AND [��� ������] = 1
GROUP BY ����, ���, �������������, [���� ��������], �����, �������