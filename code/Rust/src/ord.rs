pub trait Ordered {
    fn gt(l: &Self, r: &Self) -> bool;
    fn eq(l: &Self, r: &Self) -> bool;
}

impl Ordered for i32 {
    fn gt(l: &Self, r: &Self) -> bool { return l > r; }
    fn eq(l: &Self, r: &Self) -> bool { return l == r; }
}

impl Ordered for &str {
    fn gt(l: &Self, r: &Self) -> bool { return str::gt(*l, *r); }
    fn eq(l: &Self, r: &Self) -> bool { return str::eq(*l, *r); }
}
