﻿namespace tamagotchi_task.Domain.Entities
{
    public class CharacterTask: DomainEntity
    {
        //Название задачи уже унаследовано

        //Описание задачи
        public string? Description { get; set; }
        //Сложность (приоритет) задачи
        public string Difficulty { get; set; }
        //Тэг задачи
        public string Tag { get; set; }
        //Срок выполнения задачи (дата её "сгорания")
        public DateTime? DeadLine { get; set; } //Если что, сделаем костыль под datetime

        //Персонаж, которому принадлежит задача
        public Character Characters { get; set; } //Ссылка на таблицу Characters
    }
}