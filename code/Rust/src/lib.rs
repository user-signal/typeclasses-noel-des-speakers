mod hguid;

#[cfg(test)]
mod tests {
    use std::collections::HashMap;
    
    use crate::hguid::HGuid;
    
    #[test]
    fn guid_test() {
        let mut map: HashMap<HGuid, &str> = HashMap::new();
        let guid = HGuid::new();
        map.insert(guid, "Some string");
        let expected = Option::Some(&"Some string");
        assert_eq!(map.get(&guid), expected);
    }
}
