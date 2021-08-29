## 1. Опис на Апликација
Апликацијата што ја развивавме е едноставна игра на рефлекси и препознавање.
Квадратчиња со букви се појавуваат на екранот кои што се движат кон спротивната страна, играчот има цел да го притисне правилната буква покажана на екранот. При играње колку повеќе букви се точно погодени играта станува побрза и побрза.

Играчот има 3 животи при што кога ќе ги изгуби сите играта завршува и играчот добива резултати.

## 2. Упатство за користењe
### 2.1 Нова Игра

![](https://i.imgur.com/68SKdtSh.jpg)
<br/><br/>
Како што е прикажано на слика 1. при стартување на апликацијата играчот е представен со 3 копчиња.
Нова Игра(Start), Најдобар Резултат(High Score) и Излез(Exit).

За да се почне нова игра едноставно се притиска на копчето за нова игра.

### 2.2 Најдобар Резултат

При притискање на копчето играчот е представен со pop-up прозорец со најдобриот резултат што го има достигнато играчот.

После секоја игра ако новиот резултат е подобар од предходниот зачуван резултат новиот резултат се зачувува како нов најдобар резултат.
Овие податоци се сериализирани и се чуваат и кога се исклучува играта.

### 2.3 Правила

Правилата се едноставни, играчот треба да ја притисне правилната буква покажана на жолтиот квадрат што се движи на екранот пред да изгуби квадратот. За секоја точно погодена буква играчот добива 5 поени. За секоја покрешна притисната буква или секоја не навреме притисната буква играчот губи 5 поени и еден живот. Играчот има 3 животи пред да заврши играта. Целта на играта е да се добие што повисок резултат.

## 3. Представување на проблемот

Играта е поделена на 2 forms Form1 што е главното мени и Form2 што е самата игра.
Овие Forms се представени како 
```cs
public partial Form : Form
```
парцијални класи што ги содржи сите потребни променливи за себе и сериализирана класа
```cs
[Serializable]
class Globals
```
што ги содржи сите глобални методи и променливи

Со Form1 класата го дефинираме главното мени додека со класата Form2 ја дефинираме самата игра.

### 3.1 Зачувување на податоци
Кога играчот прв пат освојува највисок резултат, што би било првиот резултат што ќе го добие, играта прави скриен .txt фајл во Documents фолдерот што ги зачувува податоците за највисок резултат помеѓу секое уклучување на играта. При секој пристап до Највисокиот резултат од главното мени се чита истиот фајл.

### 3.2 Алгоритми и Методи
При креацијата на играта не користевме познати алгоритми, едноставно користевме потребни методи.
```cs
private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            switch (direc)
            {
                case 1:
                    lblChar.Top += speed;
                    if (lblChar.Top >= gamePanel.Height)
                    {
                        handleFail();
                        
                    }
                   
                    break;
                case 2:
                    lblChar.Left += speed;
                    if (lblChar.Left >= gamePanel.Width)
                    {
                        handleFail();
                        
                    }
                    
                    break;
            }
        }
```
		
Движењето на коцките го добивме со методот погоре, каде користиме тајмер на формата кој ја упдејтира позицијата на коцката во простор, зависно од правецот.
```lblChar.Left ``` доколку се движи лево, ```lblChar.Top ``` доколку се движи надоле, ```lblChar.Bottom ``` и```lblChar.Right ``` се read-only променлив.
### 3.2 Методи за добивање броеви по случаен избор
```getNewPoint()```,```getNewPoint()```,```GetRandomChar() ``` и ```GetRandomDirec() ``` користат методи за доделување на рандом променливи, за да ја добијат позицијата каде ќе се појави коцката, на кој правец ќе се движи како и кој симбол ќе биде во коцката. 
#### 3.3.1 Почетна Состојба
Почетната состоја ```InitializeComponent();```, Кога се повикува оваа функција се инциализира самиот Form на што е представена играта по што се повикува ```gameTimer.Start();```при што се активира тајмерот на што е базирана играта, за секој tick на тајмерот квадратчето со буквата се движи или од горниот дел на екранот надоле или од левиот дел на екранот на десно.
#### 3.3.2 Ракување со грешки
Кога играчот ќе направи грешка дали би било тоа погрешна буква е внесена или не притисната буква на време тогаш се повукува методата ```handleFail();``` што ги одстранува животите на екранот кога бројот на грешки е помал од 3 и ја завршува играта коа бројот на грешки е 3.
#### 3.3.3 Крајна Состоја
Играта постигнува крајна состојба кога бројот на згрешени или пропуштени букви станува 3 по што се повикува ```game_over();```методата што прво го представува резултатот што го добил играчот и по кликање на OK копчето играчот се враќа на првиот Form што е главното мени.
### 3.4 GUI
![](https://i.imgur.com/FAriwbd.png)
<br/><br/>
Графичкиот интерфејс за играта е едноставен, главното мени е направено од 3 копчиња и самата игра е представена со црн екран каде што се движат жолтите квадрати, со црвени букви внатре, како и копче за назад под екранот, животите се представени како 3 кругчиња, при што секоја грешка ќе смени едно кругче во X кога играчот снемува кругчиња ја губи играта. Исто така во долниот дел е представен и моменталниот резултат на играчот.
