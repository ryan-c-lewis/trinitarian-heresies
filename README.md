# trinitarian-heresies

(For reference: https://www.monergism.com/thethreshold/sdg/Trinitarian%20Heresies.html)

Analogies for the Triune God are heresy. God is *not* like an egg or a shamrock; that is Partialism. God is *not* like a man who operates as a father, a husband, and a friend; that is Modalism.

Here I'm attempting to properly represent God (and heretical representations of God) through object oriented code. This representation is just another failed analogy, but it's better than other analogies because of our ability to combine inheritance and encapsulation. (i.e. - the God class contains a Father and Son and Spirit, but each of these can itself be an instance of God.)

The codebase contains an implementation of God for each theory and tests that assert the different aspects of the orthodox theory.

# Results

| Theory        | Father = Fully God | Son = Fully God    | Spirit = Fully God | Father ≠ Son       | Father ≠ Spirit    | Son ≠ Spirit       | Son is Human       | One God            | 
|:--------------|:------------------:|:------------------:|:------------------:|:------------------:|:------------------:|:------------------:|:------------------:|:------------------:| 
| Orthodox      | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | 
| Modalism      | :white_check_mark: | :white_check_mark: | :white_check_mark: | :x:                | :x:                | :x:                | :white_check_mark: | :white_check_mark: | 
| Tritheism     | :x:                | :x:                | :x:                | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :x:                | 
| Arianism      | :white_check_mark: | :x:                | :x:                | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | 
| Docetism      | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :x:                | :white_check_mark: | 
| Ebionitism    | :white_check_mark: | :x:                | :x:                | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | 
| Macedonianism | :white_check_mark: | :white_check_mark: | :x:                | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | 
| Adoptionism   | :white_check_mark: | :x:                | :x:                | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | 
| Partialism    | :x:                | :x:                | :x:                | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | 


# Tests

```C#
[Test]
public void FatherIsFullyGod()
{
    Assert.IsTrue(God.Father.IsFullyGod());
}

[Test]
public void SonIsFullyGod()
{
    Assert.IsTrue(God.Son.IsFullyGod());
}

[Test]
public void SonIsFullyHuman()
{
    Assert.IsTrue(((Jesus) God.Son).IsHuman);
}

[Test]
public void SpiritIsFullyGod()
{
    Assert.IsTrue(God.Spirit.IsFullyGod());
}

[Test]
public void FatherIsNotSon()
{
    Assert.AreNotSame(God.Father, God.Son);
}

[Test]
public void FatherIsNotSpirit()
{
    Assert.AreNotSame(God.Father, God.Spirit);
}

[Test]
public void SonIsNotSpirit()
{
    Assert.AreNotSame(God.Son, God.Spirit);
}

[Test]
public void IsTheLordOne()
{
    Assert.IsTrue(God.IsOne());
}
```

# Theories

```C#
public class OrthodoxTheory : God
{
    public OrthodoxTheory()
    {
        Father = new PersonOfGodhead();
        Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.Full};
        Spirit = new PersonOfGodhead();
    }
}
```

```C#
public class Modalism : God
{
    public Modalism()
    {
        Father = Son = Spirit = new Jesus {IsHuman = true, Divinity = DivinityStatus.Full};
    }
}
```

```C#
public class Tritheism : God
{
    class PolytheistGod : Jesus
    {
        public override bool IsFullyGod()
        {
            return false;
        }
    }

    public Tritheism()
    {
        Father = new PolytheistGod();
        Son = new PolytheistGod {IsHuman = true, Divinity = DivinityStatus.Full};
        Spirit = new PolytheistGod();
    }

    public override bool IsOne()
    {
        return false;
    }
}
```

```C#
public class Arianism : God
{
    public Arianism()
    {
        Father = new FatherAloneAsGod();
        Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.Partial};
        Spirit = (Father as FatherAloneAsGod).Power;
    }
}
```

```C#
public class Docetism : God
{
    public Docetism()
    {
        Father = new PersonOfGodhead();
        Son = new Jesus {IsHuman = false, Divinity = DivinityStatus.Full};
        Spirit = new PersonOfGodhead();
    }
}
```

```C#
public class Ebionitism : God
{
    public Ebionitism()
    {
        Father = new FatherAloneAsGod();
        Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.None};
        Spirit = (Father as FatherAloneAsGod).Power;
    }
}
```

```C#
public class Macedonianism : God
{
    public Macedonianism()
    {
        Father = new PersonOfGodhead();
        Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.Full};
        Spirit = null;

        Task.Run(() =>
        {
            Thread.Sleep(SomePeriodOfTime);
            Spirit = new Entity();
        });
    }
}
```

```C#
public class Adoptionism : God
{
    public Adoptionism()
    {
        Father = new FatherAloneAsGod();
        Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.None};
        Spirit = (Father as FatherAloneAsGod).Power;

        Task.Run(() =>
        {
            Thread.Sleep(SomePeriodOfTime);
            (Son as Jesus).Divinity = DivinityStatus.Full;
        });
    }
}
```

```C#
public class Partialism : God
{
    class PartialGod : PersonOfGodhead
    {
        public override bool IsFullyGod()
        {
            return false;
        }
    }

    public Partialism()
    {
        Father = new PartialGod();
        Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.Partial};
        Spirit = new PartialGod();
    }
}
```
