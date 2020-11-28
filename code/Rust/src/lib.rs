mod hguid;
mod ord;
mod algorithm;

#[cfg(test)]
mod tests {
    use crate::algorithm::equality;

    #[test]
    fn guid_test() {
        use std::collections::HashMap;
        use crate::hguid::HGuid;
        let mut map: HashMap<HGuid, &str> = HashMap::new();
        let guid = HGuid::new();
        map.insert(guid, "Some string");
        let expected = Option::Some(&"Some string");
        assert_eq!(map.get(&guid), expected);
    }
    
    #[test]
    fn  int_ord_test() {
        use crate::algorithm::sort;
        let int_ords = vec!(1, -4, 42, 12);
        let actual = sort(&int_ords);
        let expected = vec!(-4, 1, 12, 42);
        assert!(equality(&actual, &expected))
    }

    #[test]
    fn  string_ord_test() {
        use crate::algorithm::sort;
        let string_ords = vec!("a", "z", "e", "r");
        let actual = sort(&string_ords);
        let expected = vec!("a", "e", "r", "z");
        assert!(equality(&actual, &expected))
    }

    #[test]
    fn  pair_ord_test() {
        use crate::algorithm::sort;
        let pair_ords = vec!((1, "a"), (-4, "z"), (-4, "e"), (42, "r"));
        let actual = sort(&pair_ords);
        let expected = vec!((-4, "e"), (-4, "z"), (1, "a"), (42, "r"));
        assert!(equality(&actual, &expected))
    }
}
