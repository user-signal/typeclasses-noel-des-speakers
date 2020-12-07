module Algorithm where

import Ordered

insert :: Ordered a => a -> [a] -> [a]
insert elem [] = [elem]
insert elem (h:t) = if gt elem h then h:(insert elem t) else elem:h:t

sort :: Ordered a => [a] -> [a]
sort = foldr insert [] 

equality :: Ordered a => [a] -> [a] -> Bool
equality list1 list2 = all (\(l,r) -> eq l r) (zip list1 list2)
