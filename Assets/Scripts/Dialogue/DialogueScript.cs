using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{
    public Dialogue[] dialogue;
    int length = 80;

    public string first = "1";
    public string second = "2";
    public string third = "3";
    public string fourth = "4";

    void Start()
    {
        dialogue = new Dialogue[length];
        for (int i = 0; i < length; i++)
        {
            dialogue[i] = new Dialogue();
        }
        FillInLines();
    }

    void FillInLines() 
    {
        int n = 0;
        dialogue[n].char_name = first;
        dialogue[n].line = "Всё-таки красиво здесь, спокойно. Нам долго ещё идти?";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Думаю, часа два. А может, и меньше, если не будем останавливаться.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Не охота мне торопиться. Зачем спешить, когда такая красота вокруг?";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "...";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Скажешь тоже. Смотри, солнце уже на закате. ";
        dialogue[n].event_type = "pause";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Эй, " + second + ", там кто-то у дороги стоит, видишь?";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Где? А, увидел.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Он нас тоже заметил.";
        dialogue[n].event_type = "pause";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Добрый вечер! В город направляетесь? ";
        dialogue[n].event_type = "add3char";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Добрый, все верно.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Не против если я к вам присоединюсь? А то все хожу один, хотелось бы компании.";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "...";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Конечно, я 1, а это 2.";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Здравствуй.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "А я 4, приятно познакомиться!";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "На отдыхе были? В это время года я часто встречаю туристов.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Да, вот решили на природу выбраться с друзьями.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Друзьями? С вами еще кто-то?";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "...";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Да, с нами еще наш друг "+ third +" пошел, но он ...";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Он пропал.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Что? Пропал? Это как?";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Ну, не то чтобы пропал, он скорее всего просто пошел вперед нас и ...";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Вы не пошли вместе?";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Мы шли вместе, но потом... мы поругались и...";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "И он пошел вперед нас.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Ясно...";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "За друга не беспокоитесь? Потеряется еще.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Нет, он бывалый походник, отлично этот лес знает. Мы беспокоились, как бы сами без него не заблудились, но обошлось.";
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Ясно...";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "А ты 4?";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "А я из местных. Раньше в город ходил автобус, но уже четыре месяца как маршрут сократили, теперь у нас каждый как может добирается. Я вот пешком хожу. Через лес быстрее, чем вдоль по объездной. ";
        n++;
        dialogue[n].char_name = "pause";
        dialogue[n].line = "...";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "А вы хороший день выбрали для похода. Жаль, сезон скоро заканчивается.";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Говорите, здесь сейчас туристов много ходит?";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Ну, не то чтобы много. Просто встречаются чаще.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Я уже несколько раз натыкался на потерявшихся, тоже как ваш друг отбивались от группы и ...";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Кстати о нем, вы как из леса выйдите – сразу наберите его, а то опыт опытом, а все-таки вечер скоро, темнеть начнет.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Да нет, с ним точно все в порядке будет.";
        n++; 
        dialogue[n].char_name = first;
        dialogue[n].line = "Он же нас раньше сам сюда водил.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "А чего вы с " + third + " не поделили, что он ушел от вас? ";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "А это уже не...";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Да ничего такого на самом деле, я бы сказал небольшое недопонимание.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = third + " сам по себе парень обидчивый, близко к сердцу все принимает. ";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Вы мне что-то недоговариваете.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Послушай, " + fourth + ", нам проблемы не нужны.";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Он остался там.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = second + ", стой...";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Мы оставили " + third + " там, в лесу!";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "Что значит «оставили»?";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Его тело. Мы не хотели...";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Как это «мы не хотели»?! А кто собирался...";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Я не думал, что все закончится вот так!";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Ты же согласился с тем, что " + third + " нужно убрать! Не прикидывайся, что не понимал, на что мы идем! ";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Это ты заставил меня! " +third+ " был моим другом!";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Ты ублюдок! Не делай из себя святошу!";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Мы убили " + third +", мы это сделали";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "Кто из нас его убил еще непонятно! Может, его прикончил один из твоих ударов!";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "Не верю в это!";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "А теперь заткнись и слушай меня: если не хочешь отправиться вслед за " +third+ " забудь все что случилось здесь. Раз и навсегда.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = third + " пошел вперед нас и пропал. Больше его никто не увидит.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = fourth + ", теперь ты с нами в одной лодке, понял? Будешь молчать до конца.";
        Debug.Log(n);

    }


    public Dialogue[] GetDialogScript() 
    {
        return dialogue;
    }
}
