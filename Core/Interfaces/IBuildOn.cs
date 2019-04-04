using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IBuildOn<T>
    {
        /// <summary>
        /// Ссылка на родителя. Если Блок обучения создан из учебного плана готовых программ 
        /// </summary>
        T Master { get; set; }
    }
}