##Builder##
Builder отделя сложно конструиране на обект от неговата конкретна решрезентация, за да е визможно чрез един и същ процес на конструиране да се създават
различни репрезентации. Директорът 'director' използва 'builder' services-те за интерпретация на различни формати. 'Builder'-ът създава част от обекта свеки
път когато е извикан от директора. Готовият продукт се връща на клиента от 'builder'-а.
