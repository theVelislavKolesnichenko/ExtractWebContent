﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace ExtractWebContent.Models
{
    public class ModelConstants
    {
        public static readonly Dictionary<int, int> formOfEducationCode = new Dictionary<int, int>()
        {
            //Бакалавър
            {2 , 1},
            //Професионален Бакалавър
            {1, 3 },
            //Магистър
            {3, 2},
            //Магистър след висше
            {5 , 4}
        };

        public static readonly Dictionary<int, int> formCode = new Dictionary<int, int>()
        {
            //Редовна
            {1, 1},
            //Вечерна
            {2, 4},
            //Задочна
            {3, 2},
            //Самостоятелна
            {6, 5},
            //Дистанционна
            {7, 3}
        };

        public static readonly List<Query> queries = new List<Query> 
        {
            //bakalawyr
             new Query(161, "АИУТ","Автоматика, информационна и управляваща техника", "действащи", 2)
            ,new Query(163, "АИУКС","Автоматика, информационни и управляващи компютърни системи", "действащи", 2)
            ,new Query(165, "АРУКС","Автоматика, роботика и управляващи компютърни системи", "действащи", 2)
            ,new Query(112, "АТ","Автомобилна техника", "действащи", 2)
            ,new Query(184, "А","Агрономство", "действащи", 2)
            ,new Query(154, "БМЕ","Биомедицинска електроника", "действащи", 2)
            ,new Query(144, "ВЕИ","Възобновяеми енергийни източници", "действащи", 2)
            ,new Query(801, "ЕТОМОС","Екология и техника за опазване на морето и околната среда", "действащи", 2)
            ,new Query(182, "ЕФП","Експлоатация на флота и пристанищата", "действащи", 2)
            ,new Query(142, "ЕЕ","Електроенергетика", "действащи", 2)
            ,new Query(507, "ЕЕЕО","Електроенергетика и електрообзавеждане", "действащи", 2)
            ,new Query(120, "E_elt","Електроника АЕО", "действащи", 2)
            ,new Query(150, "Е","Електроника", "действащи", 2)
            ,new Query(146, "ЕОК","Електрообзавеждане на кораба", "действащи", 2)//ЕОК_б
            ,new Query(141, "ЕСЕО","Електроснабдяване и електрообзавеждане", "действащи", 2)
            ,new Query(143, "ЕТ","Електротехника", "действащи", 2)
            ,new Query(147, "ЕТВЕИ","Електротехника и възобновяеми енергийни източници", "действащи", 2)
            ,new Query(148, "ЕТЕТ","Електротехника и електротехнологии", "действащи", 2)
            ,new Query(486, "ЗНБА","Защита на населението при бедствия и аварии", "действащи", 2)
            ,new Query(107, "ИНД","Индустриален дизайн", "действащи", 2)
            ,new Query(128, "IM_elt","Индустриален мениджмънт АЕО", "действащи", 2)
            ,new Query(180, "ИМ","Индустриален мениджмънт", "действащи", 2)
            ,new Query(103, "ИД","Инженерен дизайн", "действащи", 2)//ИД_б
            ,new Query(136, "ИЕ","Инженерна екология", "действащи", 2)
            ,new Query(155, "ИКТ","Информационни и комуникационни технологии", "действащи", 2)
            ,new Query(104, "КТМ","Компютъризирани технологии в машиностроенето", "действащи", 2)
            ,new Query(160, "КСТ","Компютърни системи и технологии", "действащи", 2)
            ,new Query(125, "CST_elt","Компютърни системи и технологии АЕО", "действащи", 2)
            ,new Query(151, "КТТ","Комуниукационна техника и технологии", "действащи", 2)
            ,new Query(127, "smm_elt","Корабни машини и механизми АЕО", "действащи", 2)//ME_b
            ,new Query(134, "КММ","Корабни машини и механизми", "действащи", 2)//КММ_б
            ,new Query(187, "КВ","Корабоводене", "действащи", 2)//КВ_б
            ,new Query(126, "NAV_elt","Корабоводене АЕО", "действащи", 2)//"NAVG_elt"
            ,new Query(129, "SHIPP_elt","Корабоплаване АЕО", "действащи", 2)
            ,new Query(188, "КП","Корабоплаване", "действащи", 2),
            new Query(122, "sme_elt","Корабостроене и морска техника АЕО", "действащи", 2)//NAMT
            ,new Query(132, "КМТ","Корабостроене и морска техника", "действащи", 2)
            ,new Query(189, "ЛВТ","Логистика на водния транспорт", "действащи", 2)
            ,new Query(202, "МУ","Машиностроене и уредостроене", "действащи", 2)
            ,new Query(102, "МТТ","Машиностроителна техника и технологии", "действащи", 2)
            ,new Query(111, "ПИ","Производствен инженеринг", "действащи", 2)
            ,new Query(164, "РМ","Роботика и мехатроника", "действащи", 2)
            ,new Query(162, "СИТ","Софтуерни и интернет технологии", "действащи", 2)
            ,new Query(124, "SIT_elt","Софтуерни и интернет технологии", "действащи", 2)
            ,new Query(123, "SM_elt","Социален мениджмънт", "действащи", 2)
            ,new Query(152, "СМ","Социален мениджмънт", "действащи", 2)
            ,new Query(108, "СИХНГП","Съоръжения и инсталацииза химическа, нефтена и газова промишленост", "действащи", 2)
            ,new Query(153, "ТКМТ","Телекомуникации и мобилни технологии", "действащи", 2)
            ,new Query(183, "ТТОМОС","Техника и технологии за опазване на моретои околната среда", "действащи", 2)
            ,new Query(185, "ТПИ","Технологично предприемачество и иновации", "действащи", 2)
            ,new Query(131, "Т","Топлотехника", "действащи", 2)
            ,new Query(137, "ТИП","Топлотехника и инвестиционно проектиране", "действащи", 2)
            ,new Query(135, "ТВЕИ","Топлотехника и възобновяеми енергийни източници", "действащи", 2)
            ,new Query(106, "ТТТ","Транспортна техника и технологии", "действащи", 2)
            ,new Query(105, "ХМ","Химическо машиностроене", "действащи", 2)
            
            //Profesionalen bakalawyr
            ,new Query(191, "АИУТ_К","Автоматика, информационна и управляваща техника", "действащи", 1)
            ,new Query(192, "АИУКС_К","Автоматика, информационни и управляващи компютърни системи_к", "действащи", 1)
            ,new Query(196, "АРУКС_К","Автоматика, роботика и управляващи компютърни системи", "действащи", 1)
            ,new Query(193, "БЕТ","Битова електротехника", "действащи", 1)
            ,new Query(177, "Е_К","Електроника_к", "действащи", 1)
            ,new Query(175, "ЗТТ_К","Земеделска техника и технологии", "действащи", 1)
            ,new Query(194, "ИСА","Индустриална и сградна автоматика", "действащи", 1)
            ,new Query(195, "МЕТ","Медицинска електронна техника", "действащи", 1)
            ,new Query(176, "РЕТТ","Ремонт и екплоатация на транспортна техника", "действащи", 1)
            ,new Query(174, "РЕМУ","Ремонт и експлоатация на мехатронни устройства", "действащи", 1)
            ,new Query(190, "ТТТ_К","Транспортна техника и технологии_к", "действащи", 1)
            
            //Magistyr
            //new Query(145, "ЕОК","Електрообзавеждане на кораба", "действащи", 3)
            //,new Query(133, "КММ","Корабни машини и механизми", "действащи", 3)
            //,new Query(121, "NAV_elt","Корабоводене АЕО", "действащи", 3)//NAVG_elt
            //,new Query(181, "КВ","Корабоводене", "действащи", 3)
            //
            ////MAg sled vishe
            //,new Query(6631, "МИТ","Microssoft нформационни технологии", "действащи", 5)
            //,new Query(6632, "МИТ-5","Microssoft нформационни технологии-5", "действащи", 5)
            //,new Query(6611, "SIEMENS PLC","Siemens plc технологии за управление", "действащи", 5)
            //,new Query(6696, "SIЕМЕNS РLС - пб","Siемеns рlс технологии за управление - след проф. бак.", "действащи", 5)
            //,new Query(6002, "АИУТ","Автоматика, информационна и управляваща техника", "действащи", 5)
            //,new Query(6673, "АИУТ(SIEMENS, 5)","Автоматика, информационна и управляваща техника (siемеns рlс технологии за управление)", "действащи", 5)
            //,new Query(6683, "АИУТ(САС)","Автоматика, информационна и управляваща техника (системи за автоматизация на сгради)", "действащи", 5)
            //,new Query(6062, "АИУТ-след ПБ","Автоматика, информационна и управляваща техника (след ПБ)", "действащи", 5)
            //,new Query(6662, "АИУКС","Автоматика, информационни и управляващи компютърни системи", "действащи", 5)
            //,new Query(6613, "АИУКС(SIEMENS PLC)","Автоматика, информационни и управляващи компютърни системи - siemens plc технологии за управление", "действащи", 5)
            //,new Query(6695, "АИУКС(SIEMENS)-ПБ","Автоматика, информационни и управляващи компютърни системи - siемеns рlс технологии за управление - след проф. бак.", "действащи", 5)
            //,new Query(6663, "АИУКС(САС)","Автоматика, информационни и управляващи компютърни системи - системи за автоматизация на сгради", "действащи", 5)
            //,new Query(6665, "АИУКС-ПБ","Автоматика, информационни и управляващи компютърни системи - след ОКС \"Професионален бакалвър\"", "действащи", 5)
            //,new Query(6583, "БЗУТ","Безопасни и здравословни условия на труд", "действащи", 5)
            //,new Query(6584, "БЗУТ-4","Безопасни и здравословни условия на труд - 4", "действащи", 5)
            //,new Query(6461, "ВЕИ","Възобновяеми енергийни източници", "действащи", 5)
            //,new Query(6462, "ВЕИ(ПСВЕИ)","Възобновяеми енергийни източници (Проектиране на съоръжения за ВЕИ)", "действащи", 5)
            //,new Query(6465, "ВЕИ-пб","Възобновяеми енергийни източници (след ОКС \"проф. бакалавър\")", "действащи", 5)
            //,new Query(6165, "ДВГАТ","Двигатели с вътрешно горене и автомобилна техника", "действащи", 5)
            //,new Query(6334, "ДМС-4","Диагностика на машини и съоръжения - 4", "действащи", 5)
            //,new Query(6574, "ЕСИ-4","Европейска социална интеграция - 4", "действащи", 5)
            //,new Query(6813, "ЕФП","Експлоатация на флота и пристанищата", "действащи", 5)
            //,new Query(6814, "ЕФП - 4","Експлоатация на флота и пристанищата - 4", "действащи", 5)
            //,new Query(8065, "ЕФП-6","Експлоатация на флота и пристанищата - 6", "действащи", 5)
            //,new Query(6433, "ЕЕ","Електроенергетика", "действащи", 5)
            //,new Query(6434, "ЕЕ-4","Електроенергетика - 4", "действащи", 5)
            //,new Query(6435, "ЕЕ-5","Електроенергетика - 5", "действащи", 5)
            //,new Query(6423, "ЕЕ(ЕЕМ)","Електроенергетика (електроенергиен мениджмънт)", "действащи", 5)
            //,new Query(6483, "ЕЕ(ЕЕС)","Електроенергетика (електроенергийни системи)", "действащи", 5)
            //,new Query(6484, "ЕЕ(ЕЕС)-4","Електроенергетика (електроенергийни системи)-4", "действащи", 5)
            //,new Query(6473, "ЕЕ(ПЕЕВЕИ)","Електроенергетика (производство на електрическа енергия от възобновяеми енергийниизточници)", "действащи", 5)
            //,new Query(4002, "ЕЕЕО","Електроенергетика и електрообзавеждане", "действащи", 5)
            //,new Query(6421, "ЕЕМ","Електроенергиен мениджмънт", "действащи", 5)
            //,new Query(6424, "ЕЕМ-4","Електроенергиен мениджмънт - 4", "действащи", 5)
            //,new Query(6481, "ЕЕС","Електроенергийни системи", "действащи", 5)
            //,new Query(6482, "ЕЕС-4","Електроенергийни системи - 4", "действащи", 5)
            //,new Query(6513, "Е","Електроника", "действащи", 5)
            //,new Query(6514, "Е-5","Електроника - 5", "действащи", 5)
            //,new Query(6535, "Е-ПБ","Електроника - след проф. бак.", "действащи", 5)
            //,new Query(6524, "Е(ЕСНЕИ)","Електроника (Електронни системи за нови енергийни източници)", "действащи", 5)
            //,new Query(6452, "ЕОК","Електрообзавеждане на кораба", "действащи", 5)
            //,new Query(6456, "ЕСЕОВТ","Електроснабдяване и електрообзавеждане на водния транспорт", "действащи", 5)
            //,new Query(6457, "ЕСЕОВТ-4","Електроснабдяване и електрообзавеждане на водния транспорт (4 сем.)", "действащи", 5)
            //,new Query(6453, "ЕСЕОК","Електроснабдяване и електрообзавеждане на кораба", "действащи", 5)
            //,new Query(6454, "ЕСЕОК-4","Електроснабдяване и електрообзавеждане на кораба - 4", "действащи", 5)
            //,new Query(6455, "ЕСЕОК-5","Електроснабдяване и електрообзавеждане на кораба - 5", "действащи", 5)
            //,new Query(6443, "ЕСЕОП","Електроснабдяване и електрообзавеждане на промишлеността", "действащи", 5)
            //,new Query(6444, "ЕСЕОП-4","Електроснабдяване и електрообзавеждане на промишлеността - 4", "действащи", 5)
            //,new Query(6445, "ЕСЕОП-5","Електроснабдяване и електрообзавеждане на промишлеността - 5", "действащи", 5)
            //,new Query(6413, "ЕТ","Електротехника", "действащи", 5)
            //,new Query(6414, "ЕТ-4","Електротехника (4 сем.)", "действащи", 5)
            //,new Query(6463, "ЕТ(ВЕИ)","Електротехника (възобновяеми енергийни източници)", "действащи", 5)
            //,new Query(6464, "ЕТ(ВЕИ)-4","Електротехника (възобновяеми енергийни източници)-4", "действащи", 5)
            //,new Query(6131, "ИНД","Индустриален дизайн", "действащи", 5)
            //,new Query(6132, "ИНД-4","Индустриален дизайн - 4", "действащи", 5)
            //,new Query(6213, "IM_elt","Индустриален мениджмънт АЕО", "действащи", 5)
            //,new Query(6214, "IM-4_elt","Индустриален мениджмънт АЕО", "действащи", 5)
            //,new Query(6833, "ИМ","Индустриален мениджмънт", "действащи", 5)
            //,new Query(6884, "ИМ(АМ)-4","Индустриален мениджмънт (аграрен мениджмънт) - 4с.", "действащи", 5)
            //,new Query(6863, "ИМ(КМ)","Индустриален мениджмънт (корпоративен мениджмънт)", "действащи", 5)
            //,new Query(6864, "ИМ(КМ)-4","Индустриален мениджмънт (корпоративен мениджмънт) - 4с.", "действащи", 5)
            //,new Query(6843, "ИМ(УП)","Индустриален мениджмънт (управление на проекти)", "действащи", 5)
            //,new Query(6844, "ИМ(УП)-4","Индустриален мениджмънт (управление на проекти) - 4с.", "действащи", 5)
            //,new Query(6874, "ИМ(УФК)-4","Индустриален мениджмънт (управление на фирмената конкурентоспособност) - 4с.", "действащи", 5)
            //,new Query(6834, "ИМ-4","Индустриален мениджмънт-4", "действащи", 5)
            //,new Query(6614, "ИРСА","Индустриални роботизирани системи и автоматизация", "действащи", 5)
            //,new Query(6133, "ИД","Инженерен дизайн", "действащи", 5)
            //,new Query(6134, "ИД-4","Инженерен дизайн - 4", "действащи", 5)
            //,new Query(6824, "ИЕ","Инженерна екология", "действащи", 5)
            //,new Query(6825, "ИЕ - 5","Инженерна екология - 5", "действащи", 5)
            //,new Query(6626, "ИСТ","Информационни системи и технологии", "действащи", 5)
            //,new Query(6627, "ИСТ-5","Информационни системи и технологии - 5", "действащи", 5)
            //,new Query(6636, "КС","Киберсигурност", "действащи", 5)
            //,new Query(6173, "КТМ","Компютъризирани технологии в машиностроенето", "действащи", 5)
            //,new Query(6175, "КТМ-4","Компютъризирани технологии в машиностроенето - 4", "действащи", 5)
            //,new Query(6174, "КТМ (други)","Компютъризирани технологии в машиностроенето (др.спец.)", "действащи", 5)
            //,new Query(6651, "КМК","Компютърни мрежи и комуникации", "действащи", 5)
            //,new Query(6652, "КМК-5","Компютърни мрежи и комуникации - 5", "действащи", 5)
            //,new Query(6051, "КСТ-5","Компютърни системи и технологии - 5", "действащи", 5)
            //,new Query(6633, "КСТ(МИТ)","Компютърни системи и технологии (Microsoft информационни технологии)", "действащи", 5)
            //,new Query(6635, "КСТ(МИТ)-5","Компютърни системи и технологии (Microsoft информационни технологии) - 5", "действащи", 5)
            //,new Query(6653, "КСТ(КМК)","Компютърни системи и технологии (Компютърни мрежи и комуникации)", "действащи", 5)
            //,new Query(6655, "КСТ(КМК)-5","Компютърни системи и технологии (Компютърни мрежи и комуникации) - 5", "действащи", 5)
            //,new Query(6004, "КСТ(КСМ)","Компютърни системи и технологии (Компютърни системи и мрежи)", "действащи", 5)
            //,new Query(6024, "КСТ(КСМ)-5","Компютърни системи и технологии (Компютърни системи и мрежи) - 5", "действащи", 5)
            //,new Query(6643, "КСТ(КТБ)","Компютърни системи и технологии (Компютърни технологии в бизнеса)", "действащи", 5)
            //,new Query(6645, "КСТ(КТБ)-5","Компютърни системи и технологии (Компютърни технологии в бизнеса) - 5", "действащи", 5)
            //,new Query(6605, "КСТ(КИ)-5","Компютърни системи и технологии (Компютърно инженерство) - 5", "действащи", 5)
            //,new Query(6008, "КСТ(ПСТ)","Компютърни системи и технологии (Програмни системи и технологии)", "действащи", 5)
            //,new Query(6028, "КСТ(ПСТ)-5","Компютърни системи и технологии (Програмни системи и технологии) - 5", "действащи", 5)
            //,new Query(6223, "CST(SI)_elt","Компютърни системи и технологии (софтуерно инженерство) АЕО", "действащи", 5)
            //,new Query(6623, "КСТ(СИ)","Компютърни системи и технологии (Софтуерно инженерство)", "действащи", 5)
            //,new Query(6625, "КСТ(СИ)-5","Компютърни системи и технологии (Софтуерно инженерство) - 5", "действащи", 5)
            //,new Query(6641, "КТБ","Компютърни технологии в бизнеса", "действащи", 5)
            //,new Query(6642, "КТБ-5","Компютърни технологии в бизнеса - 5", "действащи", 5)
            //,new Query(6543, "КТТ","Комуникационна техника и технологии", "действащи", 5)
            //,new Query(6544, "КТТ-4","Комуникационна техника и технологии - 4", "действащи", 5)
            //,new Query(5025, "КТТ-5","Комуникационна техника и технологии - 5", "действащи", 5)
            //,new Query(6545, "КТТ(МОК)","Комуникационна техника и технологии (мобилни и оптични комуникации)", "действащи", 5)
            //,new Query(6546, "КТТ(МОК) - 4","Комуникационна техника и технологии (мобилни и оптични комуникации) - 4", "действащи", 5)
            //,new Query(6547, "КТТ(МОК) - ПБ","Комуникационна техника и технологии (мобилни и оптични комуникации) - след проф. бак.", "действащи", 5)
            //,new Query(6343, "КММ","Корабни машини и механизми", "действащи", 5)
            //,new Query(6345, "КММ-5","Корабни машини и механизми - 5 сем.", "действащи", 5)
            //,new Query(6346, "КММ-6","Корабни машини и механизми - 6 сем.", "действащи", 5)
            //,new Query(6353, "КВ","Корабоводене", "действащи", 5)
            //,new Query(6323, "КМТ-3","Корабостроене и морска техника - 3", "действащи", 5)
            //,new Query(6324, "КМТ-4","Корабостроене и морска техника - 4", "действащи", 5)
            //,new Query(6861, "КМ","Корпоративен мениджмънт", "действащи", 5)
            //,new Query(6862, "КМ-4","Корпоративен мениджмънт - 4", "действащи", 5)
            //,new Query(9006, "КСП","Криминология и социална превенция", "действащи", 5)
            //,new Query(6815, "ЛВТ","Логистика на водния транспорт", "действащи", 5)
            //,new Query(6123, "МУ","Машиностроене и уредостроене", "действащи", 5)
            //,new Query(6113, "МТТ","Машиностроителна техника и технологии", "действащи", 5)
            //,new Query(6114, "МТТ-4","Машиностроителна техника и технологии - 4", "действащи", 5)
            //,new Query(6115, "МТТ-ПБ","Машиностроителна техника и технологии - след ОКС \"Професионален бакалавър\"", "действащи", 5)
            //,new Query(6541, "МОК","Мобилни и оптични комуникации", "действащи", 5)
            //,new Query(6542, "МОК-4","Мобилни и оптични комуникации - 4", "действащи", 5)
            //,new Query(6325, "ПМУС","Проектиране на морски уредби и системи", "действащи", 5)
            //,new Query(6431, "ПЕЕВЕИ","Производство на електрическа енергия от ВЕИ", "действащи", 5)
            //,new Query(6432, "ПЕЕВЕИ-4","Производство на електрическа енергия от ВЕИ - 4", "действащи", 5)
            //,new Query(6893, "ПППМ","Производство на посевен и посадъчен материал", "действащи", 5)
            //,new Query(6894, "ПППМ-4","Производство на посевен и посадъчен материал - 4", "действащи", 5)
            //,new Query(6891, "СПРЗ","Семепроизводство и растителна защита", "действащи", 5)
            //,new Query(6892, "СПРЗ-4","Семепроизводство и растителна защита - 4", "действащи", 5)
            //,new Query(6661, "САС","Системи за автоматизация на сгради", "действащи", 5)
            //,new Query(6637, "СИИ","Системи за изкуствен интелект", "действащи", 5)
            //,new Query(6621, "СИ","Софтуерно инженерство", "действащи", 5)
            //,new Query(6622, "СИ-5","Софтуерно инженерство - 5", "действащи", 5)
            //,new Query(6593, "СМ","Социален мениджмънт", "действащи", 5)
            //,new Query(6594, "СМ-4","Социален мениджмънт - 4", "действащи", 5)
            //,new Query(6563, "СРЛДП","Социална работа при лица с девиантно поведение", "действащи", 5)
            //,new Query(6564, "СРЛДП-4","Социална работа при лица с девиантно поведение - 4", "действащи", 5)
            //,new Query(6553, "СРД","Социална работа с деца", "действащи", 5)
            //,new Query(6554, "СРД-4","Социална работа с деца - 4", "действащи", 5)
            //,new Query(6565, "СП","Социално предприемачество", "действащи", 5)
            //,new Query(6566, "СП-4","Социално предприемачество - 4", "действащи", 5)
            //,new Query(6116, "СТЗ","Съвременни технологии в земеделието", "действащи", 5)
            //,new Query(6548, "ТКМТ","Телекомуникации и мобилни технологии", "действащи", 5)
            //,new Query(6549, "ТКМТ-4","Телекомуникации и мобилни технологии (4 сем.)", "действащи", 5)
            //,new Query(6536, "ТКМТ-ПБ","Телекомуникации и мобилни технологии (след ПБ)", "действащи", 5)
            //,new Query(6111, "ТТОМ","Техника и технологии за обработване на материалите", "действащи", 5)
            //,new Query(6112, "ТТОМ-4","Техника и технологии за обработване на материалите - 4", "действащи", 5)
            //,new Query(6823, "ТТОМОС","Техника и технологии за опазване на морето и околната среда", "действащи", 5)
            //,new Query(6831, "ТПИ","Технологично предприемачество и иновации", "действащи", 5)
            //,new Query(6832, "ТПИ-4","Технологично предприемачество и иновации - 4", "действащи", 5)
            //,new Query(6143, "ТМСЗП","Технология, машини и системи за заваръчното производство", "действащи", 5)
            //,new Query(6313, "Т","Топлотехника", "действащи", 5)
            //,new Query(6314, "Т-4","Топлотехника - 4", "действащи", 5)
            //,new Query(6315, "Т-5","Топлотехника - 5", "действащи", 5)
            //,new Query(6311, "ТВЕИ","Топлотехника и възобновяеми енергийни източници", "действащи", 5)
            //,new Query(6312, "ТВЕИ-6","Топлотехника и възобновяеми енергийни източници - 6", "действащи", 5)
            //,new Query(6153, "ТТТ","Транспортна техника и технологии", "действащи", 5)
            //,new Query(6155, "ТТТ-5","Транспортна техника и технологии - 5", "действащи", 5)
            //,new Query(6156, "ТТТ-ПБ","Транспортна техника и технологии - след проф. бак.", "действащи", 5)
            //,new Query(9008, "УКУТ","Управление и контрол на условията на труд", "действащи", 5)
            //,new Query(6183, "ХМ","Химическо машиностроене", "действащи", 5)
            //,new Query(6184, "ХМ-4","Химическо машиностроене - 4", "действащи", 5)
            //,new Query(6185, "ХМ-ПБ","Химическо машиностроене след проф. бак.", "действащи", 5)
        };

        public static readonly List<int> form = new List<int> 
        {
            1, //Редовна
            2, //Вечерна
            3, //Задочна
            //6, //Самостоятелна
            //7, //Дистанционна
        };
        
        public static readonly List<int> kurs = new List<int>
        {
            1,
            2,
            3,
            4,
            5,
            6,
            //7,
        };

        public static readonly List<int> grupa = new List<int>
        {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8
        };
    }
}
