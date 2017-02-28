﻿namespace _02.DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Namespaces
    {
        // Неимспейсите: идеята им е, логически да разделят накакви части
        // и някакви типове данни във вашето приложение. С други думи, като кажете
        // NamespaceSystem вътре да се намират неща свързани със системата,
        // Могат да съдържат всякакви типове данни, както и други неймспейси.
        // Не могът да съдържат методи и данни директно в тях-те трябва първо да са в Дефиниции на
        // типове или с други думи (класове, структури...). Ако не се напише namespace- се води глобалния нейм-
        // спейс, ПИШЕТЕ ВИНАГИ НЕЙМСПЕЙСИ И ГИ КРЪЩАВАЙТЕ АДЕКВАТНО!!! Това ви подрежда логически цялото приложение!!!
        // Името му трябва да е адекватно на съдържанието разбира се ! 
        // Идеята е: че всички неща в един и същ неймспейс, могат да се виждат помежду си
        // ако са в различни, вие изрично трябва да кажете (с using ...) че искате да използвате даден неймспейс!!!
        // Концепцията им е да използваме само нещата който ни трябват, а не вичко и ненужните неща, да ни бавят инатоварват. 
        // Затова е това разпределение(структуриране, подреждане) в неймспейси. 
        // Всеки един Неймспейс НЕ е задължително да се дефинира в един и същ файл(може да са в различни с един и същ неймспейс,
        // това означава, че са близки) например в namespace Animal , могътр да бъдат класове и Dog и Cat и техните производни 
        // класове методи свойства тн... 
        // Ето това е как се достъпва определна информация в опр. нейм.. using System.Collections.Generic;
        // всичките тия using - и са референции към тези неймспейсове и данните в тях
        // Точката разграничава Поднеймспейси!!!!! Примерно- using System; и  using System.Collections.Generic; и using System.Linq;
        // Това е един неймспейс System , но имат различни поднеймспеиси .Collections.Generic  ,  .Linq и тн...
        // ТОВА НИ ПОЗВОЛЯВА ОЩЕ ПО ДОБРЕ ДА ГРУПИРАМЕ, РАЗГРАНИЧАВАМЕ И ОРГАНИЗИРАМЕ ПРОГРАМИТЕ СИ!!! 
        // АКО ЕДИН КЛАС Е МН ДЪЛЪГ-РАЗДЕЛЯТЕ НА МН КЛАСОВЕ, АКО ИМАТЕ ПРЕКАЛЕНО МН КЛАСОВЕ РАЗДЕЛЯТЕ ГИ В НЕЙМСПЕЙСОВЕ, АКО ИМАТЕ МН НЕЙМСПС РАЗДЕЛЯТЕ ГИ НА ОТДЕЛНИ ПРОЕКТИ И ТН..
        // АКО ЕДИН МЕТОД Е МН ДЪЛГ РАЗДЕЛЯТЕ НА МН МЕТОДИ И ТН...
        // 


    }
}