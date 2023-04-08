# Zenject_Interface_abstract
Пет-проект сделанный с использолванием фреймворка Zenject и с использованием интерфейсов и абстрактных классов.

В данной игре у нас пристствует абстрактный класс "PlayerAction" который определяет базовую логику действий игрока, которые могут быть выполнены через нажатие на кнопки на клавиатуре или мыши. В этом классе определен абстрактный метод Execute(), который должен быть реализован в классах-наследниках.
Я также создал конкретный класс AttackAction, который наследуется от PlayerAction и реализует метод Execute(). Этот класс определяет логику атаки игрока, используя интерфейс IEnemyService для поиска ближайшего врага и нанесения ему урона.
Чтобы использовать AttackAction, я добавил его как переменную в класс PlayerController и вызываю его метод Execute() в ответ на нажатие соответствующей клавиши. Я также передаю gameObject как параметр методу Execute(), чтобы он знал, на какой объект должна быть нацелена атака.

Zenject : 
В классе PlayerInstaller я использую Zenject для связывания интерфейса IInventoryService с его реализацией InventoryService. Также я использую Zenject для внедрения зависимости IEnemyService в PlayerController.

В классе GameInstaller я использую Zenject для создания экземпляров сервисов IEnemyService и IInventoryService, и связывания их с их реализациями.

В классе EnemyService мы используем Zenject для получения экземпляра IEnemyService, и вызываем его методы для получения списка врагов и нанесения им урона.


Список скриптов :
1. Player (PlayerAction-abstract class, JumpAction, UseItemAction, AttackAction, PlayerController) / (InventoryService) / (IInventoryService)
2. Item (Item class)
3. Enemy (Enemy, EnemyService) / (IEnemyService)

