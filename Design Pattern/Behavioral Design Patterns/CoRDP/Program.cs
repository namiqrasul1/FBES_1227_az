using CoRDP;

Withdraw wit = new()
{
    Id = 1,
    Amount = 300,
};

Worker ishci = new("Islam");
Moderator mod = new("Rustem");
Ceo ceo = new("Ayshan");

ishci.SetNext(mod);
mod.SetNext(ceo);

ishci.Process(wit);

