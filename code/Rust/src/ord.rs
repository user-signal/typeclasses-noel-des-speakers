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

impl<A: Ordered, B: Ordered> Ordered for (A, B) {
    fn gt(l: &Self, r: &Self) -> bool {
        A::gt(&l.0, &r.0) || (A::eq(&l.0, &r.0) && B::gt(&l.1, &r.1))
    }
    fn eq(l: &Self, r: &Self) -> bool {
        A::eq(&l.0, &r.0) && B::eq(&l.1, &r.1)
    }
}