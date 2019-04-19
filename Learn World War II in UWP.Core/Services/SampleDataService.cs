using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Learn_World_War_II_in_UWP.Core.Models;

namespace Learn_World_War_II_in_UWP.Core.Services
{
    // This class holds sample data used by some generated pages to show how they can be used.
    // TODO WTS: Delete this file once your app is using real data.
    public static class SampleDataService
    {
        private static IEnumerable<SampleOrder> AllOrders()
        {
            // The following is order summary data
            var data = new ObservableCollection<SampleOrder>
            {
                new SampleOrder
                {
                   OrderId = 01,
                    GeneralPic="/Assets/10GENERALS/Bernard Law MontgomeryP.jpg",
                    Lived = "1887-1976",
                    Allegiance="United Kingdom",
                    Occupation="Field Marshal 陆军元帅 ",
                    Company = "BERNARD MONTGOMERY 伯纳德·劳·蒙哥马利", //string
                    knownAs = "The Spartan General,斯巴达将军" ,//string
                    
                   GeneralPic2="/Assets/10GENERALS/10GPic/01/001.jpg",
                     GeneralPic3="/Assets/10GENERALS/10GPic/01/02.jpg",
                      GeneralPic4="/Assets/10GENERALS/10GPic/01/003.jpg",
                       GeneralPic5="/Assets/10GENERALS/10GPic/01/375px-Monty,_wavvel,_auk.jpg",

                    PersonNote1="第一代阿拉曼的蒙哥马利子爵伯纳德·劳·蒙哥马利，KG，GCB，DSO，PC（Bernard Law Montgomery, 1st Viscount Montgomery of Alamein，1887年11月17日－1976年3月24日），英国陆军元帅，第二次世界大战中著名的军事指挥官。1887年11月17日出生在伦敦肯宁顿区圣马克教区的牧师家庭。1901年14岁时才正式上学，文化课成绩极差，但体育成绩极好。1908年，毕业于英国桑赫斯特皇家军事学院，12月任英国驻印度的皇家沃里克郡团少尉排长。参加第一次世界大战，后升任旅参谋长和师作战参谋。大战结束时任师司令部中校参谋。在2002年，BBC举行了一个名为“最伟大的100名英国人”的调查，结果蒙哥马利得第88名。领军战斗最著名的经典战役就是击倒“沙漠之狐”隆美尔，在阿拉曼战役时与之对垒超过100日，并以海、空军封锁西西里海峡，致使隆美尔弹尽援绝而撤军。成为盟军在非洲有保障的伟人。",
                    PersonNote2="第二次世界大战爆发时，蒙哥马利率远征军第3师横渡英吉利海峡，参加了在法国和比利时的战斗。1940年5月，德军闪击西欧时，英远征军被迫从敦刻尔克撤回英国，在撤离的前夕，蒙哥马利奉命接任即将回国的艾伦·布鲁克（1941年12月出任帝国总参谋长）的军长职务，指挥第2军的撤退行动。1940年7月，晋升为第5军军长。1941年4月，蒙哥马利改任第12军军长。同年12月升任东南军区司令，晋升为中将。负责选拔、调整、 培养各级指挥官，严格训练部队，提高军事素质。1942年7月，北非沙漠中的英国第8军团，被有“沙漠之狐”之称的隆美尔德国非洲军团击败，退守埃及境内的阿莱曼地区。次月，在英军濒临崩溃之际，他接任了第8集团军司令。同年10月至11月，他组织向德军发动阿拉曼战役，一举击溃隆美尔非洲军团，扭转北非战局。随后又挥师乘胜追击，协同美军将德、意军队围歼于突尼斯。他由此声誉大振，被人们称之为捕捉“沙漠之狐”的猎手。后来丘吉尔说到：“阿拉曼战役之前，我们是战无不败；阿拉曼战役之后，我们是战无不胜。”蒙哥马利因此役而晋升为上将，获得巴思骑士勋章。1943年7月，他率英军在西西里登陆。同年9月至12月，协同美军开展意大利战役，进军意大利半岛。1944年1月，蒙哥马利调任盟军第21集团军司令，参与诺曼底登陆战役的计划制定工作。1944年6月6日，诺曼底登陆作战开始。蒙哥马利以第21集团军（辖英国第2军团、美国第1军团和加拿大第1军团）司令的身份兼任盟军地面部队司令，具体指挥并协调地面部队的作战行动。8月1日，美国第12集团军（辖美国第1军团和第3军团）组成，布莱德雷任集团军司令。蒙哥马利开始协调2个集团军的作战。1944年9月1日，艾森豪威尔将司令部移驻法国，从蒙哥马利手中正式接管地面部队指挥权，并晋升为元帅，仅指挥第21集团军。1944年9月17日，蒙哥马利向驻荷兰德军发起代号为“市场花园行动”的军事行动，不料遭遇德军的顽强抵抗，以致盟军付出了伤亡惨重的代价，行动遭到惨败。1945年3月23日，蒙哥马利指挥盟军第21集团军和美国第9军团，在空军和空降兵的协同下开始强渡莱茵河向德国腹地推进的作战。强渡莱茵河后，蒙哥马利与艾森豪就盟军主要突击方向发生分歧，主张向柏林快速突击，先于苏军攻占柏林。此举遭到后者否定。同年4月，盟军第21集团军和美国第12集团军对鲁尔实施合围，迫使德国B集团军32万余人投降。此后英军继续向易北河挺进，攻占吕内堡和汉堡。5月2日抵达波罗的海沿岸的维斯马和卢卑克，封锁丹麦半岛。5月4日在吕内堡接受在荷兰、弗里兰斯、石勒苏益格—荷尔斯泰因和丹麦境内的全部德军的投降。"
                },
                new SampleOrder
                {
                    OrderId = 02,
                    GeneralPic="/Assets/10GENERALS/Chester-W.-Nimitz-militarymuseumP.jpg",
                    Lived = "1885-1966",
                    Allegiance="United States of America",
                    Occupation ="Five-star General 五星上将 ",
                    Company = "Chester William Nimitz 切斯特·威廉·尼米兹",
                    knownAs = "Chief of Naval Operations",

                     GeneralPic2="/Assets/10GENERALS/10GPic/02/270px-Adm._Chester_W._Nimitz_and_Adm._William_F._Halsey_aboard_USS_Curtiss_(AV-4)_at_Espiritu_Santo,_20_January_1943_(80-G-34822).jpg",
                     GeneralPic3="/Assets/10GENERALS/10GPic/02/330px-Nimitz_on_Grayling;0820904.jpg",
                      GeneralPic4="/Assets/10GENERALS/10GPic/02/330px-USS_Lexington_(CV-2)_burning_and_sinking_on_8_May_1942.jpg",
                       GeneralPic5="/Assets/10GENERALS/10GPic/02/Attack_on_Pearl_Harbor_Japanese_planes_view.jpg",

                    PersonNote1 ="老切斯特·威廉·尼米兹（英语：Chester William Nimitz, Sr.，1885年2月24日－1966年2月20日）是一位美国海军将领，最高军衔为五星上将。尼米兹早期以研究潜艇为主，而后成为美军中柴油引擎技术的专家，太平洋战争爆发后，尼米兹担任了美国太平洋舰队总司令、太平洋战区盟军总司令等职务，主导对日作战，军事历史学家艾德温·帕尔玛·霍利（Edwin Palmer Hoyt）因而评论：“哈尔西能在一场海战中取胜，斯普鲁恩斯能在一场战役中取胜，而尼米兹能在一场战争中取胜”。 战后，尼米兹担任海军作战部长，一直至1947年退役为止。尼米兹于1966年逝世。美国海军为纪念尼米兹，而将其去世之后所建造的第一艘、也是当时最新锐的航空母舰尼米兹级核动力航空母舰以他为名，也就是日后的尼米兹号航空母舰。此外，美国夏威夷檀香山及加州旧金山有以他为名的尼米兹高速公路。",
                    PersonNote2="中途岛，面积只有4.7平方公里，其特殊的地理位置决定了它战略地位的重要性。该岛距美国旧金山和日本横滨均相距2800海里，处于亚洲和北美之间的太平洋航线的中途，故名中途岛。另外它距珍珠港1135海里，是美国在中太平洋地区的重要军事基地和交通枢纽，也是美军在夏威夷的门户和前哨阵地。中途岛一但失守，美太平洋舰队的大本营珍珠港也将唇亡齿寒。日本自1941年12月7日偷袭珍珠港开始，发动了太平洋战争，以后在3个多月的时间里便占领了东自威克岛、马绍尔群岛，西至马来半岛、安达曼和尼科巴各岛，南至俾斯麦群岛地区，几乎完全控制了整个西太平洋。在这几个月里，日本军队每取得一次胜利，被战争狂热煽动起来的东京市民就排着长队，挥舞着纸制太阳旗，涌到皇宫门前举行祝捷大会。然而，在这些热闹欢腾的背后，有一个人总显得心事重重。此人便是日本海军联合舰队司令山本五十六大将。日军偷袭珍珠港成功后，他就曾冷静而清醒地指出：我们只是唤醒了一个巨人，必须在巨人尚未起身之前，完成袭击珍珠港未竟之事业，彻底击毁美太平洋舰队。因此，山本竭力赞成联合舰队参谋长宇垣少将提出的进攻中途岛的计划，认为若能占领该岛，则既可将该岛作为日机空中巡逻的前进基地，威逼夏威夷，又可诱出美舰队，在决战中予以歼灭。攻克硫黄岛之后，1945年4月1日，尼米兹命令向冲绳岛发起突击，守岛日军殊死抵抗，'神风'攻击队则向美军舰船发动自杀性进攻。6月22日，该岛陷落。美军伤亡近5万，日军伤亡近12万。"
                },
                new SampleOrder
                {
                    OrderId = 03,
                    GeneralPic="/Assets/10GENERALS/Douglas MacArthurP.jpg",
                    Lived = "1880-1964",
                    Allegiance ="United States of America",
                    Occupation ="Five-star General 五星上将 ",
                    Company = "DOUGLAS MACARTHUR 道格拉斯·麦克阿瑟",
                    knownAs = "Chief of Naval Operations",

                      GeneralPic2="/Assets/10GENERALS/10GPic/03/330px-MacArthur_arrives_at_Atsugi;ac01732.jpg",
                     GeneralPic3="/Assets/10GENERALS/10GPic/03/330px-Macarthur_hirohito.jpg",
                      GeneralPic4="/Assets/10GENERALS/10GPic/03/440px-Douglas_MacArthur_speaking_at_Soldier_Field_HD-SN-99-03036.JPEG",
                       GeneralPic5="/Assets/10GENERALS/10GPic/03/440px-IncheonLandingMcArthur.jpg",

                    PersonNote1 ="1944年麦克阿瑟被授予陆军五星上将。第二次世界大战时期历任美国远东军司令，西南太平洋战区盟军司令；战后出任驻日盟军最高司令和“联合国军”总司令等职。1964年4月5日，麦克阿瑟在沃尔特·里德陆军医院（美国陆军医疗中心）因胆结石去世，享年84岁。麦克阿瑟因在菲律宾战役中的表现获颁荣誉勋章，和父亲阿瑟·麦克阿瑟是史上第一对同时获得荣誉勋章的父子。麦克阿瑟是美国陆海空三军中获得勋章最多的将军，也是美国将军中唯一一个参加过第一次世界大战，第二次世界大战和朝鲜战争的人。麦克阿瑟是美国最年轻的准将、西点军校最年轻的校长、美国陆军历史上最年轻的陆军参谋长。麦克阿瑟被美国国民称之为“一代老兵”。",
                    PersonNote2="道格拉斯·麦克阿瑟是美国历史上杰出的，也是最有争议的将领，他所受到的赞誉和非议都超过了其他美国将领。他的确是一个个性极其复杂而丰富多彩的人，很难用一个固定的框框去套他。在第二次世界大战耀眼的19颗星中，他既不像艾森豪威尔那样和颜悦色、平易近人、讨人喜欢，也不像巴顿那样个性鲜明、鲁莽率直、热情豪放，更不像马歇尔那样宽宏大度、虚怀若谷、公正无私。他是一片五彩云，集赤青黄白黑于一身；他是一杯五味酒，融酸甜苦辣咸于一体。如果说麦克阿瑟在战场上是位叱咤风云的军事统帅，那么他在政坛上则是位雷厉风行的改革大师，尽管罗斯福曾说他不是一个好的政治家，尽管他三次竞选总统皆告惨败。研究他的人大都认为，他留给后人的最大业绩，是他成功地使日本从封建军国主义走向现代民主主义。在占领日本期间，他把天皇的权威转到自己手中，使用专制独裁的手段使日本永远摆脱封建专制独裁。在这一点上，麦克阿瑟算得上一位高瞻远瞩的英雄，他把资产阶级民主强加于日本人，从而造就了战后的新日本。当然，作为一个保守甚至反动的资产阶级卫道士，他也成功地镇压了日本历史上最大规模的民众运动，致力于把日本建成'反共堤坝'。纵观麦克阿瑟的一生，他的确取得过最辉煌的成就，赢得过最耀眼的荣誉。这些荣誉他当之无愧，但也不可避免地使他本来优良的品质渐渐溶进狂妄自大、唯我独尊、好出风头、爱慕虚荣、喜欢颂扬的毛病。这些毛病带给他的倔强个性又常常使他的一些计划和设想得以强行通过并获得极大成功，这反过来更使他坚信自己的判断力和正确性，更加重了那些毛病，以致最后发展到公然抗上的地步。如此看来，正是他的高傲自负成就了他的军事奇迹，也正是他的高傲自负断送了他的军事生涯。"

                },
                new SampleOrder
                {
                    OrderId = 04,
                    GeneralPic ="/Assets/10GENERALS/Dwight_D_EisenhowerP.jpg",
                    Lived = "1890-1969",
                    Allegiance ="United States of America",
                    Occupation ="Five-star General 五星上将 ",
                    Company = "Dwight David Eisenhower 德怀特·戴维·艾森豪威尔",
                    knownAs = "Ike",

                      GeneralPic2="/Assets/10GENERALS/10GPic/04/300px-New_Government_of_the_U.S._-_NARA_-_5730034.jpg",
                     GeneralPic3="/Assets/10GENERALS/10GPic/04/1951_Chung_Baik_Eisenhower.jpg",
                      GeneralPic4="/Assets/10GENERALS/10GPic/04/330px-Funeral_services_for_Dwight_D._Eisenhower,_March_1969.jpg",
                       GeneralPic5="/Assets/10GENERALS/10GPic/04/450px-U.S._President_Eisenhower_visited_TAIWAN_美國總統艾森豪於1960年6月訪問臺灣台北時與蔣中正總統-2.jpg",

                      PersonNote1="德怀特·戴维·艾森豪威尔（Dwight David Eisenhower，1890年10月14日—1969年3月28日），美国第34任总统（1953年－1961年在任），政治家，军事家。艾森豪威尔出生于美国德克萨斯州丹尼森的一个已经破产的基督徒家庭，他在艰苦生活中磨砺了意志。1915年毕业于西点军校，毕业时在班上排在第61名，只得到军士长的军衔。后在得克萨斯州圣安东尼第19步兵师服役，少尉军衔。然而后来他却成为了10位五星上将中晋升“第一快”，出身 “第一穷”，也是美军统帅最大战役行动的第一人。第二次世界大战期间，他担任盟军在欧洲的最高指挥官，1944年至1945年里负责计划和执行监督进攻维希法国和纳粹德国的行动。1948年2月退役，任哥伦比亚大学校长至1953年（但从1950年起一直缺席而担任北约司令）。1952年作为共和党总统候选人参加竞选总统获胜，成为美国第34任总统，1956年再次竞选获胜，蝉联总统。1969年3月28日在华盛顿因心脏病逝世。美国的权威期刊《大西洋月刊》评为影响美国的100位人物第28名。",
                    PersonNote2="1939年第二次世界大战爆发后不久回国，历任营长、师参谋长、军参谋长、集团军参谋长。因工作成绩优异，受陆军参谋长G.C.马歇尔赏识。1941年9月晋准将。太平洋战争爆发后任陆军参谋部作战计划处副处长、处长，负责组织向太平洋战场增调防御力量。1942年3月任作战处处长，支持‘先欧后亚’的战略方针，主张集中兵力于英格兰，尽快在西欧开辟第二战场，沿最近路线攻入德国本土。1942年6月任欧洲战区美军司令，为在法国登陆做准备。11月作为北非远征军总司令，指挥实施北非登陆战役。1943年2月任地中海战区盟军总司令，组织实施突尼斯战役，结束北非战事。随后指挥西西里岛登陆战役和意大利南部战役，迫使意大利投降并对德宣战。12月任盟国欧洲远征军最高司令。 1944年6月组织实施诺曼底登陆战役，指挥盟军将德军逐出法国，直捣德国腹地。同年12月晋陆军五星上将。他具有卓越的组织领导能力，精于计划，善于协同，指挥果断，处事有方，为反法西斯战争的最后胜利做出重要贡献。1945年7月任美国驻德国占领军总司令。同年12月任美国陆军参谋长。1948年5月退役后任哥伦比亚大学校长。1950年再次服现役，任北大西洋条约组织武装力量最高司令。1952年11月当选为美国第34任总统。任内大力发展核武器和空军，推行大规模报复战略和战争边缘政策。1954年12月与台湾当局签订共同安全条约。1957年1月连任总统，提出插手中东事务的‘艾森豪威尔主义’。1958年7月出兵干涉黎巴嫩。"
                },
                new SampleOrder
                {
                    OrderId = 05,
                   GeneralPic="/Assets/10GENERALS/Erwin RommelP.jpg",
                   Lived = "1891-1944",
                   Allegiance="Nazi Germany",
                    Occupation ="Field marshal 元帅 ",
                    Company = "ERICH VON MANSTEIN 埃尔温·隆美尔",
                    knownAs = "The Desert Fox",

                      GeneralPic2="/Assets/10GENERALS/10GPic/05/375px-Bundesarchiv_Bild_101I-013-0064-35,_Polen,_Bormann,_Hitler,_Rommel,_v._Reichenau.jpg",
                     GeneralPic3="/Assets/10GENERALS/10GPic/05/375px-Rommel_with_his_aides.jpg",
                      GeneralPic4="/Assets/10GENERALS/10GPic/05/Bundesarchiv_Bild_183-1987-0313-503,_Goslar,_Hitler_schreitet_Ehrenkompanie_ab.jpg",
                       GeneralPic5="/Assets/10GENERALS/10GPic/05/Bundesarchiv_Bild_146-1970-076-43,_Paris,_Erwin_Rommel_bei_Siegesparade.jpg",

                  PersonNote1="埃尔温·隆美尔（德语：Erwin Rommel，1891年11月15日—1944年10月14日），出生于符腾堡邦海登海姆市，纳粹德国陆军元帅，世界军事史上著名的军事家、战术家、理论家。隆美尔绰号“沙漠之狐”、“帝国之鹰”，与曼施坦因与古德里安一起被后人并称为第二次世界大战期间纳粹德国的三大名将 [1]  。1910年7月从军，一战时随军开赴法国，后又在东线与罗马尼亚人和意大利人作战，被德皇授予蓝马克斯勋章。一战后曾担任过步兵营长、陆军学院教官。1938年隆美尔少将任元首大本营司令。1940年2月任德军第7装甲师师长，使该师赢得了“魔鬼之师”的称号。1941年1月希特勒挑选隆美尔中将任驻非洲军团军长。他到达北非后，不到两个月，就迅速扭转了北非战局的初期局势，被提拔为上将，1942年6月被晋升为德国陆军元帅。二战期间，隆美尔被卷进了密谋推翻希特勒的计划中，在希特勒的逼迫之下，隆美尔被迫于在1944年10月14日在卡车上服毒自尽，时年53岁。 在第二次世界大战的璀璨将星中，能够做到生前声名显赫，身后殊荣不断，特别是被敌对双方都认可的，只有隆美尔一人。对他的评价也逐渐趋于两极化，支持的人将其称为纳粹战神，他高明的军事素质和出色的战术指挥才能，受到了许多军事爱好者的尊崇，甚至是著名军事家的尊敬和崇拜；反对的人根据他战略的失误，将其称为“战术上的巨人，战略上的矮子”；但鉴于隆美尔既曾经是希特勒麾下最得力的将领之一，又是纳粹政权的侵略工具，因此也被称为“二战纵火犯”。",
                    PersonNote2="曼施坦因、隆美尔、古德里安被后人并称为第二次世界大战期间纳粹德国的三大名将。当然，从政治角度和和平来说，从客观上讲，他们绝对是助纣为虐的法西斯帮凶，对别国犯下了不可饶恕的战争罪行，是希特勒祸害天下的杀手。不过他们并不支持希特勒的屠杀，他们只是在尽军人的本分而已。而从军事角度来看，他们过人的军事素质，出色的军事指挥艺术，对世界军事历史产生了重大影响，确实值得后人研究。与那些制造屠杀的纳粹德国政客们和党卫军首脑相比，身为正规的德国国防军优秀将领的他们还算清白，他们虽在希特勒的战争中策划指挥，却反对纳粹的屠杀和灭绝政策，更没有参与屠杀暴行。也许正因为这点，加上他们令人惊叹的军事造诣，使他们赢得了敌国的尊敬和历史学家，军事学家的客观评价。丘吉尔曾在一次演讲中讲道：“尽管我们在战争中互相厮杀，但请允许我说，他是一位伟大的将军。”"
                },
                new SampleOrder
                {
                    OrderId = 06,

                    Company = "Georgy Konstantinovich Zhukov 格奥尔吉·康斯坦丁诺维奇·朱可夫",

                    Lived = "1896-1974",
                     GeneralPic="/Assets/10GENERALS/Georgy Konstantinovich ZhukovP.jpg",

                    Allegiance ="Soviet Union",
                    Occupation ="Marshal of the Soviet Union 苏联元帅 ",

                    knownAs = "Fireman，Marshal",

                      GeneralPic2="/Assets/10GENERALS/10GPic/06/375px-Bundesarchiv_Bild_183-14059-0018,_Berlin,_Oberbefehlshaber_der_vier_Verbündeten.jpg",
                     GeneralPic3="/Assets/10GENERALS/10GPic/06/375px-Montgomery_receives_Order_of_Victory_HD-SN-99-02756_cropped.JPG",
                      GeneralPic4="/Assets/10GENERALS/10GPic/06/Zhukov_1945_E010750410-v8.jpg",
                       GeneralPic5="/Assets/10GENERALS/10GPic/06/375px-Allies_at_the_Brandenburg_Gate,_1945.jpg",

                  PersonNote1="格奥尔吉·康斯坦丁诺维奇·朱可夫（俄语：Гео́ргий Константи́нович Жу́ков/英语：Georgy Konstantinovich Zhukov，1896年12月1日-1974年6月18日），1943年1月18日，朱可夫被授予苏联元帅军衔，是苏德战争中第一位获此殊荣的苏军统帅，因其在苏德战争中的卓越功勋，被公认为是第二次世界大战中最优秀的将领之一，也因此成为仅有的四次荣膺苏联英雄荣誉称号的两人之一。",
                    PersonNote2="朱可夫在从士兵到元帅的漫长军旅生涯中立下了举世公认的赫赫战功。四次荣膺苏联英雄称号（1939年8月29日，1944年7月29日，1945年6月1日，1956年12月1日），是仅有的四次荣膺苏联英雄荣誉称号的两人之一。荣获列宁勋章6枚，十月革命勋章1枚，红旗勋章3枚，一级苏沃洛夫勋章2枚，“胜利”最高军功勋章2枚，图瓦共和国“共和国”勋章1枚，蒙古人民共和国英雄(1969年)，荣誉武器1件，奖章及外国勋章多枚。防空军事指挥学院以其名字命名。他不但为打败德国法西斯的侵略作出了重大贡献，而且其指挥艺术也为苏联军事学术的发展起到巨大推进作用。他成为第二次世界大战中战功卓著的“传奇元帅”。他在苏联卫国战争中的杰出贡献，使他成为与苏沃洛夫、米哈伊尔·库图佐夫相提并论的俄罗斯民族英雄，永载史册。正如他的挚友艾森豪威尔上将所赞颂的那样“牺牲的军人们到达天堂时，一定会得到另一枚荣誉勋章，那就是朱可夫勋章，这种勋章将被每一位赞赏军人的勇敢、眼光、坚毅和决心的人所珍视。”"
                },
                new SampleOrder
                {
                    OrderId = 07,

                    Company = "GEORGE PATTON (1888-1954)海因茨·威廉·古德里安",

                    Lived = "1888-1954",
                     GeneralPic="/Assets/10GENERALS/Heinz Wilhelm GuderianP.jpg",

                    Allegiance ="Nazi Germany",
                    Occupation ="Generaloberst, in English Colonel General",

                    knownAs = "Schneller Heinz",

                      GeneralPic2="/Assets/10GENERALS/10GPic/07/300px-Bundesarchiv_Bild_101I-139-1112-17,_Heinz_Guderian.jpg",
                     GeneralPic3="/Assets/10GENERALS/10GPic/07/440px-Tigerfibel_cover.jpg",
                      GeneralPic4="/Assets/10GENERALS/10GPic/07/440px-Военные_манёвры,_Германия,_1935.2.jpg",
                       GeneralPic5="/Assets/10GENERALS/10GPic/07/091220_guderian.jpg",

                   PersonNote1="海因茨·威廉·古德里安（德语：Heinz Wilhelm Guderian，1888年6月17日－1954年5月14日）是第二次世界大战一位著名的德国陆军将领，最高军衔为大将。古德里安为第二次世界大战爆发前，提倡坦克与机械化部队使用于现代化战争的重要推动者，在他组织与推动理论下，德国建立了一支当时作战最具效率的装甲部队，于第二次世界大战初期以新型战争型态：“闪击战”并屡屡击败敌军，古德里安也是联合兵种作战和前线指挥等战争型态发展的推动者。",
                    PersonNote2="古德里安在第二次世界大战中担任了装甲部队的指挥官，在波兰战役期间指挥了第19装甲军进行快速的突穿攻势，与苏联军队会师。在1940年的西线战役中，古德里安担任A集团军群第19装甲军军长，为西线主攻的装甲兵力矛头之一。攻势发起后，古德里安指挥部队通过了被盟军认为坦克难以横越的阿登森林，直驶英吉利海峡，将困于比利时的盟军包围消灭，这次军事行动的成功令德国乃至全世界体会到装甲部队在现代战争中的重要性；1941年6月德国发动“巴巴罗萨作战”入侵苏联，古德里安出任中央集团军群的第2装甲兵团司令，指挥德军装甲师完成多次包围歼灭战，直趋苏联首都莫斯科，但在阿道夫·希特勒命令下，古德里安放弃其原先的目标，转而率军南下进行史上规模最大的包围歼灭战“基辅战役”，这场战役虽然以德军的胜利结束，但因为延误的时间而使德军必须在极不利的冬季状态下进攻莫斯科，古德里安也因此被免职。1943年德国于“斯大林格勒战役”中惨败后，古德里安复出成为了装甲兵总监，进行重建装甲部队的工作，进而发动世界上规模最大的装甲战斗“库尔斯克会战”，虽然德军在战场上占尽优势，将3倍人数于德军的苏军打败，但是由于美军在西西里岛登陆使得希特勒下令德军回防。1944年7月古德里安出任陆军参谋长，这是他所晋升到的最高职位，但于战争结束前不久被免职。古德里安现今成为了德国发展装甲兵力的代表人物，被历史学家称作“闪击战之父”和“世界装甲车之父” ，同时也因为其急躁和直爽的个性而被部下取了个“急速海因茨”（Schneller Heinz）的绰号。"
                },
                new SampleOrder
                {
                    OrderId = 08,

                    Company = "George Smith Patton Jr.小乔治·史密斯·巴顿 1855-1945",

                    Lived = "1855-1945",
                     GeneralPic="/Assets/10GENERALS/GEORGE PATTONP.jpg",

                    Allegiance ="United States of America",
                    Occupation ="General 上将 ",

                    knownAs = "Bandito，Old Blood and Guts",

                      GeneralPic2="/Assets/10GENERALS/10GPic/08/440px-George_S._Patton_-_France_-_1918.jpg",
                     GeneralPic3="/Assets/10GENERALS/10GPic/08/440px-Ohrdruf_Corpses_Eisenhower.jpg",
                      GeneralPic4="/Assets/10GENERALS/10GPic/08/440px-Patton_speaking_with_Lt._Col._Lyle_Bernard,_at_Brolo,_circa_1943.jpg",
                       GeneralPic5="/Assets/10GENERALS/10GPic/08/600px-Patton_during_a_welcome_home_parade_in_Los_Angeles,_June_9,_1945.jpg",

                 PersonNote1="小乔治·史密斯·巴顿（George Smith Patton, Jr.，1885年11月11日－1945年12月21日）是美国陆军四星上将，以在第二次世界大战欧洲战场先后指挥美国陆军第7集团军和第3集团军而闻名。巴顿于1885年出生在一个优越的家庭，家中有悠久的军事背景。他先进入维吉尼亚军事学校学习，之后入读西点军校。他曾参加1912年夏季奥运会，也是M1913型军刀（又称“巴顿军刀”）的设计者。巴顿在潘乔维拉远征期间首次参与战斗，这一战也是最早的机械化作战实例之一。之后他加入了美国远征军新成立的坦克军并参加第一次世界大战。巴顿在战争期间首度统领位于法国的美国坦克学校，不过到战争快要结束时因负伤离职。在战间期，巴顿一直是美国陆军装甲战学说发展的一个核心人物，在全国各地出任过众多职位。他的军衔不断得到提升，并在美国卷入第二次世界大战时成为第2装甲师的指挥官。1942年，巴顿带领美军官兵在北非战场通过入侵卡萨布兰卡进入地中海战场，并在这里迅速恢复了第2军受挫的士气，从而建立了身为一位有效率指挥官的名声。西西里岛战役期间他指挥第7集团军，抢在英国将军伯纳德·蒙哥马利之前攻下墨西拿，但也在这里因打了两名士兵耳光而卷入争议，并被暂时解除指挥权。1944年，巴顿回到战场，在诺曼底战役中指挥第3集团军成功地实施了一场快速穿越法国的行动。突出部之役期间，他带领第3集团军解救了被围困在巴斯通的美军，并在战争结束前率先带领自己的部队进入德国本土。",
                    PersonNote2="巴顿多姿多彩的形象、难以驾驭的个性和身为指挥官的成功有时会被报刊上有关他在政治上不称职的陈述所掩盖，但他在战场上身先士卒的领导风范，以及利用对第3集团军所做的这类粗俗演讲来激励部下的能力，已经成为美国军官队伍中新的领导哲学。他高度重视快速和咄咄逼人的攻势催生了多兵种协同作战的新战略。盟国领袖对巴顿持有不同的看法，而他在德国国防军最高统帅部的对手却都给予他高度评价。1970年上映的美国传记电影《巴顿将军》获得了很大成功，在第43届奥斯卡金像奖角逐中夺得了包括最佳影片在内的7项大奖，将巴顿转变为一位美国民族英雄并带入流行文化中。"
                },
                new SampleOrder
                {
                    OrderId = 09,

                    Company = "Isoroku Yamamoto:山本五十六1884-1943",

                    Lived = "1884-1943",
                     GeneralPic="/Assets/10GENERALS/Isoroku YamamotoP.jpg",

                    Allegiance ="Empire of Japan",
                    Occupation ="Commander-in-Chief，Marshal admiral 元帅 海军大将",

                    knownAs = "高野五十六，",

                      GeneralPic2="/Assets/10GENERALS/10GPic/09/440px-Pearl_Harbor-_Nakajima_B5N2_over_Hickam-_80G178985.jpg",
                     GeneralPic3="/Assets/10GENERALS/10GPic/09/Isoroku_Yamamoto_41_.jpg",
                      GeneralPic4="/Assets/10GENERALS/10GPic/09/Yamamoto_last_image_alive.jpg",
                       GeneralPic5="/Assets/10GENERALS/10GPic/09/Yamamoto_state_funeral.jpg",

                   PersonNote1="山本五十六（日語：山本 五十六／やまもと いそろく，1884年4月4日－1943年4月18日），旧日本海军军人，曾留学美国哈佛大学，第二次世界大战期间担任日本海军联合舰队司令长官。山本五十六在日本海军中历任重要职位，进行了多项重大变更与改革，尤其是亲手组建了日本海军航空兵部队。在太平洋战争早期担任日本海军联合舰队司令长官并策划或指挥了数次战役，例如偷袭珍珠港以及中途岛战役。山本在1943年搭乘飞机前往所罗门群岛前线视察的路上遭美军P-38闪电式战斗机拦截，座机（一式大型陆上运输机）被击落。山本之死对日本军队士气造成了沉重打击。",
                    PersonNote2="山本持有坚定的反战思想。认识到以日本的国力无法支持长期战争，山本公开反对入侵满洲、与中国爆发全面战争、加入三国轴心，以及与美国交战。在1930年以海军少将身份参加伦敦海军会议时，山本仍持有扩张海军的观点，曾当众对以财政原因主张裁军的大藏省官员贺屋兴宣大骂“贺屋闭嘴，否则别怪我动手打人”。但回国后目睹民众热烈欢迎谈判使团的场面受到触动，以此为契机产生了反战观点。而且他坚决反对德意日三国结盟。由于曾长年在美国任职并就读于哈佛大学，山本明显亲美。对于盟友纳粹德国山本并不寄予厚望，不过在死后仍获纳粹德国颁发橡叶双剑骑士铁十字勋章。山本准确地预测到航空母舰在太平洋战争中的主力地位，还创造了将六艘大型航舰集中使用的用兵思路。另外，山本经常委任属下有能力的参谋军官如源田实制定战役计划。渊田美津雄认为山本将大和号闲置在离战场很远的地方是巨大错误，还特别猛批了伊号作战中把刚重建的舰载机部队投入陆上消耗战的作法，认为山本是一个平庸之将。山本被认为任人过于看重私交，典型的例子就是黑岛龟人和宇垣缠。他在重要的问题上一向信任黑岛。松田千秋任大和舰长行礼时，宇垣说：“虽然我是参谋长，但只是摆设，一切都是山本和黑岛说了算。山本指挥下的联合舰队拥有明显的弱点，例如缺乏护航的商船队在美国海军潜艇部队的拦截下伤亡惨重，导致日军后勤线中断，时常缺乏战略资源。日本海军的密码被美军破译，这直接引致了山本一生之中最大的败绩——损失四艘航舰和228架飞机的中途岛海战。美国海军史专家莫里森直接称攻击珍珠港是“愚蠢之举”。1945年8月15日玉音放送后，海军兵学校监事长大西新藏中将当着全体学生的面说“中途岛之役战败时，山本元帅应该切腹的。”认为山本的温情主义（指不处罚南云忠一）和情报战败北是很大的错误。"
                },
                new SampleOrder
                {
                    OrderId = 10,
                  GeneralPic="/Assets/10GENERALS/General_BradleyP.jpg",
                    Company = "Omar Bradley 奥马尔·纳尔逊·布莱德雷 1893-1981",

                    Lived = "1893-1981",



                    Allegiance ="United States of America",
                    Occupation ="Five-star General 五星上将 ",

                    knownAs = "Brad，The G.I.'s General",

                      GeneralPic2="/Assets/10GENERALS/10GPic/10/340px-Omarbradleywestpoint.jpg",
                     GeneralPic3="/Assets/10GENERALS/10GPic/10/Cherbourg_1944_s191143.jpg",
                      GeneralPic4="/Assets/10GENERALS/10GPic/10/General_Montgomery_with_Generals_Patton_(left)_and_Bradley_(centre)_at_21st_Army_Group_HQ,_Normandy,_7_July_1944._B6551.jpg",
                       GeneralPic5="/Assets/10GENERALS/10GPic/10/Marshall_arnold_and_bradley.jpg",

                     PersonNote1="奥马尔·纳尔逊·布拉德利（英语：Omar Nelson Bradley，1893年2月12日－1981年4月8日），是美国陆军的五星上将，第二次世界大战期间美军在北非战场和欧洲战场的主要指挥官。他是四星上将同时也是最后一位辞世的五星上将，同时也是第一任参谋长联席会议主席。",
                    PersonNote2="珍珠港事件2個月後，先後就任第82狙擊師、第28狙擊師和Keystone師師長，負責上述各師的組建與訓練，1943年2月，被任命為第X軍軍長，還沒有就任任命就被取消，到北非為他的老同學艾森豪服務，後任第II軍副軍長、軍長，第I集團軍（後來改稱第XII集團軍）司令兼任第I軍團軍長，他領導的第XII集團軍總人數曾達90萬3千人，是美國歷史上作為軍團這一級美國陸軍軍官指揮過的人數最多的作戰部隊。1945年8月，就任退伍軍人局局長，1948年2月7日，任陸軍參謀長，1949年8月16日，成為第一任參謀長聯席會議主席，1950年9月22日被授予五星上將軍階，是美國國防機構中最後一個被晉升為五星上將的人，也是二戰後的唯一一位。1949年10月5日，成為第一任NATO軍事委員會主席，1953年8月15日退休。"
                },
            };

            return data;
        }

        private static string _localResourcesPath;

        private static ObservableCollection<SampleImage> _gallerySampleData;

        public static void Initialize(string localResourcesPath)
        {
            _localResourcesPath = localResourcesPath;
        }

        // TODO WTS: Remove this once your image gallery page is displaying real data.
        public static ObservableCollection<SampleImage> GetGallerySampleData()
        {
            if (_gallerySampleData == null)
            {
                _gallerySampleData = new ObservableCollection<SampleImage>();
                for (int i = 1; i <= 54; i++)
                {
                    _gallerySampleData.Add(new SampleImage()
                    {
                        ID = $"{i}",
                        Source = $"{_localResourcesPath}/SampleData/SamplePhoto{i}.png",
                        Name = $"Image sample {i}"
                    });
                }
            }

            return _gallerySampleData;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data.
        public static async Task<IEnumerable<SampleOrder>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllOrders();
        }
    }
}
