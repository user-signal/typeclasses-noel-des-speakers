pub trait NSOrd {
    fn gt(&self, that: &Self) -> bool;
    fn eq(&self, that: &Self) -> bool;
}

impl NSOrd for i32 {
    fn gt(&self, that: &Self) -> bool { return self > that; }
    fn eq(&self, that: &Self) -> bool { return self == that; }
}

impl NSOrd for &str {
    fn gt(&self, that: &Self) -> bool { return str::gt(*self, *that); }
    fn eq(&self, that: &Self) -> bool { return str::eq(*self, *that); }
}
