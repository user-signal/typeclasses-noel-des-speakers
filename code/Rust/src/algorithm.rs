use crate::ord::Ordered;

pub fn sort<T: Ordered + Clone>(source: &Vec<T>) -> Vec<T> {
    let mut result: Vec<T> = Vec::new();
    for s in source {
        let position =
            match result.iter().position(|r| Ordered::gt(r, &s)) {
                None => result.len(),
                Some(p) => p
            };
        result.insert(position, s.clone());
    }
    return result;
}

pub fn equality<T: Ordered>(vector1: &Vec<T>, vector2: &Vec<T>) -> bool {
    vector1.len() == 
        vector2.len() && 
        vector1.iter()
            .zip(vector2.iter())
            .all(|p| Ordered::eq(p.0, p.1))
}