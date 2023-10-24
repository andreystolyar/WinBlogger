using Microsoft.EntityFrameworkCore;
using WinBlogger.Model;

namespace WinBlogger.DataAccess;

public class DataMigrator : IDataMigrator
{
  /*
  public void ApplyMigrations()
  {
    using var db = new WinBloggerDbContext();
    db.Database.Migrate();
  }
  */

  public void SeedDatabase(WinBloggerDbContext db)
  {
    db.Database.Migrate();

    SeedBloggers(db);
    //SeedBlogs(db);
    //SeedPosts(db);
    //SeedComments(db);

    db.SaveChanges();
  }

  static void SeedBloggers(WinBloggerDbContext db)
  {
    //todo: add posts' titles and comments
    var bloggers = new List<Blogger>
    {
      new Blogger
      {
        Nickname = "Schopenhauer",

        FullName = "Arthur Schopenhauer",

        Avatar = "01_schopenhauer.png",

        Blog = new Blog
        {
          Title = "The World as Will and Representation",
          Description = "The World as Will and Representation is the central work of the German philosopher Arthur Schopenhauer. The first edition was published in late 1818, with the date 1819 on the title-page. A second, two-volume edition appeared in 1844: volume one was an edited version of the 1818 edition, while volume two consisted of commentary on the ideas expounded in volume one. A third expanded edition was published in 1859, the year prior to Schopenhauer's death. In 1948, an abridged version was edited by Thomas Mann.",

          Posts = new List<Post>
          {
            new Post
            {
              Title = "Tragedy/Comedy",
              Text = "The life of every individual, viewed as a whole and in general, and when only its most significant features are emphasized, is really a tragedy; but gone through in detail it has the character of a comedy.",
              Created = DateTime.Now,
            },
            new Post
            {
              Title = "Let us speak the truth",
              Text = "Life is short and truth works far and lives long: let us speak the truth.",
              Created = DateTime.Now,
            },
            new Post
            {
              Title = "",
              Text = "What keeps all living things busy and in motion is the striving to exist. But when existence is secured, they do not know what to do: that is why the second thing that sets them in motion is a striving to get rid of the burden of existence, not to feel it any longer, 'to kill time', i.e. to escape boredom.",
              Created = DateTime.Now,
            },
            new Post
            {
              Title = "",
              Text = "And to this world, to this scene of tormented and agonised beings, who only continue to exist by devouring each other, in which, therefore, every ravenous beast is the living grave of thousands of others, and its self-maintenance is a chain of painful deaths; and in which the capacity for feeling pain increases with knowledge, and therefore reaches its highest degree in man, a degree which is the higher the more intelligent the man is; to this world it has been sought to apply the system of optimism, and demonstrate to us that it is the best of all possible worlds. The absurdity is glaring.",
              Created = DateTime.Now,
            },
            new Post
            {
              Title = "",
              Text = "It is really incredible how meaningless and insignificant when seen from without, and how dull and senseless when felt from within, is the course of life of the great majority of men. It is weary longing and worrying, a dreamlike staggering through the four ages of life to death, accompanied by a series of trivial thoughts. They are like clockwork that is wound up and goes without knowing why. Every time a man is begotten and born the clock of human life is wound up anew, to repeat once more its same old tune that has already been played innumerable times, movement by movement and measure by measure, with insignificant variations. Every individual, every human apparition and its course of life, is only one more short dream of the endless spirit of nature, of the persistent will-to-live, is only one more fleeting form, playfully sketched by it on its infinite page, space and time; it is allowed to exist for a short while that is infinitesimal compared with these, and is then effaced, to make new room. Yet, and here is to be found the serious side of life, each of these fleeting forms, these empty fancies, must be paid for by the whole will-to-live in all its intensity with many deep sorrows, and finally with a bitter death, long feared and finally made manifest. It is for this reason that the sight of a corpse suddenly makes us serious.",
              Created = DateTime.Now,
            },
          },

        }
      },
      new Blogger
      {
        Nickname = "Spinoza",
        FullName = "Baruch Spinoza",
        Avatar = "02_spinoza.png",

        Blog = new Blog
        {
          Title = "Ethics",
          Description = "Ethics, Demonstrated in Geometrical Order (Latin: Ethica, ordine geometrico demonstrata), usually known as the Ethics, is a philosophical treatise written in Latin by Baruch Spinoza (Benedictus de Spinoza). It was written between 1661 and 1675 and was first published posthumously in 1677. /nThe book is perhaps the most ambitious attempt to apply the method of Euclid in philosophy. Spinoza puts forward a small number of definitions and axioms from which he attempts to derive hundreds of propositions and corollaries, such as \"When the Mind imagines its own lack of power, it is saddened by it\", \"A free man thinks of nothing less than of death\", and \"The human Mind cannot be absolutely destroyed with the Body, but something of it remains which is eternal.\"",

          Posts = new List<Post>
          {
            new Post
            {
              Title = "God is Existence",
              Text = "By that which is self—caused, I mean that of which the essence involves existence, or that of which the nature is only conceivable as existent.",
              Created = DateTime.Now,
            },
            new Post
            {
              Title = "Part I, Appendix",
              Text = "In the foregoing I have explained the nature and properties of God. I have shown that he necessarily exists, that he is one: that he is, and acts solely by the necessity of his own nature; that he is the free cause of all things, and how he is so; that all things are in God, and so depend on him, that without him they could neither exist nor be conceived; lastly, that all things are predetermined by God, not through his free will or absolute fiat, but from the very nature of God or infinite power. I have further, where occasion afforded, taken care to remove the prejudices, which might impede the comprehension of my demonstrations. Yet there still remain misconceptions not a few, which might and may prove very grave hindrances to the understanding of the concatenation of things, as I have explained it above. I have therefore thought it worth while to bring these misconceptions before the bar of reason. \nAll such opinions spring from the notion commonly entertained, that all things in nature act as men themselves act, namely, with an end in view. It is accepted as certain, that God himself directs all things to a definite goal (for it is said that God made all things for man, and man that he might worship him). I will, therefore, consider this opinion, asking first, why it obtains general credence, and why all men are naturally so prone to adopt it? secondly, I will point out its falsity; and, lastly, I will show how it has given rise to prejudices about good and bad, right and wrong, praise and blame, order and confusion, beauty and ugliness, and the like. However, this is not the place to deduce these misconceptions from the nature of the human mind: it will be sufficient here, if I assume as a starting point, what ought to be universally admitted, namely, that all men are born ignorant of the causes of things, that all have the desire to seek for what is useful to them, and that they are conscious of such desire. Herefrom it follows, first, that men think themselves free inasmuch as they are conscious of their volitions and desires, and never even dream, in their ignorance, of the causes which have disposed them so to wish and desire. Secondly, that men do all things for an end, namely, for that which is useful to them, and which they seek. Thus it comes to pass that they only look for a knowledge of the final causes of events, and when these are learned, they are content, as having no cause for further doubt. If they cannot learn such causes from external sources, they are compelled to turn to considering themselves, and reflecting what end would have induced them personally to bring about the given event, and thus they necessarily judge other natures by their own. Further, as they find in themselves and outside themselves many means which assist them not a little in the search for what is useful, for instance, eyes for seeing, teeth for chewing, herbs and animals for yielding food, the sun for giving light, the sea for breeding fish, &c., they come to look on the whole of nature as a means for obtaining such conveniences. Now as they are aware, that they found these conveniences and did not make them, they think they have cause for believing, that some other being has made them for their use. As they look upon things as means, they cannot believe them to be self—created; but, judging from the means which they are accustomed to prepare for themselves, they are bound to believe in some ruler or rulers of the universe endowed with human freedom, who have arranged and adapted everything for human use. They are bound to estimate the nature of such rulers (having no information on the subject) in accordance with their own nature, and therefore they assert that the gods ordained everything for the use of man, in order to bind man to themselves and obtain from him the highest honor. Hence also it follows, that everyone thought out for himself, according to his abilities, a different way of worshipping God, so that God might love him more than his fellows, and direct the whole course of nature for the satisfaction of his blind cupidity and insatiable avarice. Thus the prejudice developed into superstition, and took deep root in the human mind; and for this reason everyone strove most zealously to understand and explain the final causes of things; but in their endeavor to show that nature does nothing in vain, i.e. nothing which is useless to man, they only seem to have demonstrated that nature, the gods, and men are all mad together. Consider, I pray you, the result: among the many helps of nature they were bound to find some hindrances, such as storms, earthquakes, diseases, &c.: so they declared that such things happen, because the gods are angry at some wrong done to them by men, or at some fault committed in their worship. Experience day by day protested and showed by infinite examples, that good and evil fortunes fall to the lot of pious and impious alike; still they would not abandon their inveterate prejudice, for it was more easy for them to class such contradictions among other unknown things of whose use they were ignorant, and thus to retain their actual and innate condition of ignorance, than to destroy the whole fabric of their reasoning and start afresh. They therefore laid down as an axiom, that God's judgments far transcend human understanding. Such a doctrine might well have sufficed to conceal the truth from the human race for all eternity, if mathematics had not furnished another standard of verity in considering solely the essence and properties of figures without regard to their final causes. There are other reasons (which I need not mention here) besides mathematics, which might have caused men's minds to be directed to these general prejudices, and have led them to the knowledge of the truth. \nI have now sufficiently explained my first point. There is no need to show at length, that nature has no particular goal in view, and that final causes are mere human figments. This, I think, is already evident enough, both from the causes and foundations on which I have shown such prejudice to be based, and also from Prop. xvi., and the Corollary of Prop. xxxii., and, in fact, all those propositions in which I have shown, that everything in nature proceeds from a sort of necessity, and with the utmost perfection. However, I will add a few remarks, in order to overthrow this doctrine of a final cause utterly. That which is really a cause it considers as an effect, and vice versâ: it makes that which is by nature first to be last, and that which is highest and most perfect to be most imperfect. Passing over the questions of cause and priority as self—evident, it is plain from Props. xxi., xxii., xxiii. that the effect is most perfect which is produced immediately by God; the effect which requires for its production several intermediate causes is, in that respect, more imperfect. But if those things which were made immediately by God were made to enable him to attain his end, then the things which come after, for the sake of which the first were made, are necessarily the most excellent of all. \nFurther, this doctrine does away with the perfection of God: for, if God acts for an object, he necessarily desires something which he lacks. Certainly, theologians and metaphysicians draw a distinction between the object of want and the object of assimilation; still they confess that God made all things for the sake of himself, not for the sake of creation. They are unable to point to anything prior to creation, except God himself, as an object for which God should act, and are therefore driven to admit (as they clearly must), that God lacked those things for whose attainment he created means, and further that he desired them. \nWe must not omit to notice that the followers of this doctrine, anxious to display their talent in assigning final causes, have imported a new method of argument in proof of their theory—namely, a reduction, not to the impossible, but to ignorance; thus showing that they have no other method of exhibiting their doctrine. For example, if a stone falls from a roof on to someone's head, and kills him, they will demonstrate by their new method, that the stone fell in order to kill the man; for, if it had not by God's will fallen with that object, how could so many circumstances (and there are often many concurrent circumstances) have all happened together by chance? Perhaps you will answer that the event is due to the facts that the wind was blowing, and the man was walking that way. \"But why,\" they will insist, \"was the wind blowing, and why was the man at that very time walking that way?\" If you again answer, that the wind had then sprung up because the sea had begun to be agitated the day before, the weather being previously calm, and that the man had been invited by a friend, they will again insist: \"But why was the sea agitated, and why was the man invited at that time?\" So they will pursue their questions from cause to cause, till at last you take refuge in the will of God—in other words, the sanctuary of ignorance. So, again, when they survey the frame of the human body, they are amazed; and being ignorant of the causes of so great a work of art, conclude that it has been fashioned, not mechanically, but by divine and supernatural skill, and has been so put together that one part shall not hurt another. \nHence anyone who seeks for the true causes of miracles, and strives to understand natural phenomena as an intelligent being, and not to gaze at them like a fool, is set down and denounced as an impious heretic by those, whom the masses adore as the interpreters of nature and the gods. Such persons know that, with the removal of ignorance, the wonder which forms their only available means for proving and preserving their authority would vanish also. But I now quit this subject, and pass on to my third point. \nAfter men persuaded themselves, that everything which is created is created for their sake, they were bound to consider as the chief quality in everything that which is most useful to themselves, and to account those things the best of all which have the most beneficial effect on mankind. Further, they were bound to form abstract notions for the explanation of the nature of things, such as goodness, badness, order, confusion, warmth, cold, beauty, deformity, and so on; and from the belief that they are free agents arose the further notions of praise and blame, sin and merit. \nI will speak of these latter hereafter, when I treat of human nature; the former I will briefly explain here. \nEverything which conduces to health and the worship of God they have called good, everything which hinders these objects they have styled bad; and inasmuch as those who do not understand the nature of things do not verify phenomena in any way, but merely imagine them after a fashion, and mistake their imagination for understanding, such persons firmly believe that there is an order in things, being really ignorant both of things and their own nature. When phenomena are of such a kind, that the impression they make on our senses requires little effort of imagination, and can consequently be easily remembered, we say that they are well—ordered; if the contrary, that they are ill—ordered or confused. Further, as things which are easily imagined are more pleasing to us, men prefer order to confusion—as though there were any order in nature, except in relation to our imagination—and say that God has created all things in order; thus, without knowing it, attributing imagination to God, unless, indeed, they would have it that God foresaw human imagination, and arranged everything, so that it should be most easily imagined. If this be their theory, they would not, perhaps, be daunted by the fact that we find an infinite number of phenomena, far surpassing our imagination, and very many others which confound its weakness. But enough has been said on this subject. The other abstract notions are nothing but modes of imagining, in which the imagination is differently affected: though they are considered by the ignorant as the chief attributes of things, inasmuch as they believe that everything was created for the sake of themselves; and, according as they are affected by it, style it good or bad, healthy or rotten and corrupt. For instance, if the motion which objects we see communicate to our nerves be conducive to health, the objects causing it are styled beautiful; if a contrary motion be excited, they are styled ugly. \nThings which are perceived through our sense of smell are styled fragrant or fetid; if through our taste, sweet or bitter, full—flavored or insipid; if through our touch, hard or soft, rough or smooth, &c. \nWhatsoever affects our ears is said to give rise to noise, sound, or harmony. In this last case, there are men lunatic enough to believe, that even God himself takes pleasure in harmony; and philosophers are not lacking who have persuaded themselves, that the motion of the heavenly bodies gives rise to harmony—all of which instances sufficiently show that everyone judges of things according to the state of his brain, or rather mistakes for things the forms of his imagination. We need no longer wonder that there have arisen all the controversies we have witnessed, and finally skepticism: for, although human bodies in many respects agree, yet in very many others they differ; so that what seems good to one seems bad to another; what seems well ordered to one seems confused to another; what is pleasing to one displeases another, and so on. I need not further enumerate, because this is not the place to treat the subject at length, and also because the fact is sufficiently well known. It is commonly said: \"So many men, so many minds; everyone is wise in his own way; brains differ as completely as palates.\" All of which proverbs show, that men judge of things according to their mental disposition, and rather imagine than understand: for, if they understood phenomena, they would, as mathematicians attest, be convinced, if not attracted, by what I have urged. \nWe have now perceived, that all the explanations commonly given of nature are mere modes of imagining, and do not indicate the true nature of anything, but only the constitution of the imagination; and, although they have names, as though they were entities, existing externally to the imagination, I call them entities imaginary rather than real; and, therefore, all arguments against us drawn from such abstractions are easily rebutted. \nMany argue in this way. If all things follow from a necessity of the absolutely perfect nature of God, why are there so many imperfections in nature? such, for instance, as things corrupt to the point of putridity, loathsome deformity, confusion, evil, sin, &c. But these reasoners are, as I have said, easily confuted, for the perfection of things is to be reckoned only from their own nature and power; things are not more or less perfect, according as they delight or offend human senses, or according as they are serviceable or repugnant to mankind. To those who ask why God did not so create all men, that they should be governed only by reason, I give no answer but this: because matter was not lacking to him for the creation of every degree of perfection from highest to lowest; or, more strictly, because the laws of his nature are so vast, as to suffice for the production of everything conceivable by an infinite intelligence, as I have shown in Prop. xvi. \nSuch are the misconceptions I have undertaken to note; if there are any more of the same sort, everyone may easily dissipate them for himself with the aid of a little reflection.",
              Created = DateTime.Now,
            },
            new Post
            {
              Title = "PROP. XLIX.",
              Text = "Love or hatred towards a thing, which we conceive to be free, must, other conditions being similar, be greater than if it were felt towards a thing acting by necessity. \nProof.—A thing which we conceive as free must (I. Def. vii.) be perceived through itself without anything else. If, therefore, we conceive it as the cause of pleasure or pain, we shall therefore (III. xiii. note) love it or hate it, and shall do so with the utmost love or hatred that can arise from the given emotion. But if the thing which causes the emotion be conceived as acting by necessity, we shall then (by the same Def. vii. Part I.) conceive it not as the sole cause, but as one of the causes of the emotion, and therefore our love or hatred towards it will be less. Q.E.D. \nNote.—Hence it follows, that men, thinking themselves to be free, feel more love or hatred towards one another than towards anything else: to this consideration we must add the imitation of emotions treated of in III. xxvii., xxxiv., xl. and xliii.",
              Created = DateTime.Now,
            },
            new Post
            {
              Title = "",
              Text = " ...everyone is fond of narrating his own exploits, and displaying the force both of his body and mind, and also that, for this reason, men are troublesome to one another. Again, it follows that men are naturally envious (III. xxiv. note, and III. xxxii. note), rejoicing in the shortcomings of their equals, and feeling pain at their virtues.",
              Created = DateTime.Now,
            },
          }
        }
      },
      new Blogger
      {
        Nickname = "Nietzsche",
        FullName = "Friedrich Wilhelm Nietzsche",
        Avatar = "03_nietzsche.png",
        Blog = new Blog
        {
          Title = "Nietzsche's Quotes",

          Description = "",

          Posts = new List<Post>
          {
            new Post
            {
              Title = "Morality",
              Text = "Morality is neither rational nor absolute nor natural. World has known many moral systems, each of which advances claims universality; all moral systems are therefore particular, serving a specific purpose for their propagators or creators, and enforcing a certain regime that disciplines human beings for social life by narrowing our perspectives and limiting our horizons.",
              Created = DateTime.Now,
            },
            new Post
            {
              Title = "God is dead",
              Text = "God is dead. God remains dead. And we have killed him. How shall we comfort ourselves, the murderers of all murderers? What was holiest and mightiest of all that the world has yet owned has bled to death under our knives: who will wipe this blood off us? What water is there for us to clean ourselves? What festivals of atonement, what sacred games shall we have to invent? Is not the greatness of this deed too great for us? Must we ourselves not become gods simply to appear worthy of it?",
              Created = DateTime.Now,
            },
            new Post
            {
              Title = "",
              Text = "In individuals, insanity is rare; but in groups, parties, nations and epochs, it is the rule.",
              Created = DateTime.Now,
            },
          }
        }
      },
      new Blogger
      {
        Nickname = "Kant",
        FullName = "Immanuel Kant",
        Avatar = "04_kant.png",
      },
      new Blogger
      {
        Nickname = "Descartes",
        FullName = "Rene Descartes",
        Avatar = "05_descartes.png",
      }
    };

    db.Bloggers.AddRange(bloggers);
  }

  void SeedBlogs(WinBloggerDbContext db)
  {
    throw new NotImplementedException();
  }

  void SeedPosts(WinBloggerDbContext db)
  {
    throw new NotImplementedException();
  }

  void SeedComments(WinBloggerDbContext db)
  {
    throw new NotImplementedException();
  }
}
