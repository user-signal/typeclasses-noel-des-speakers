{-# LANGUAGE TypeSynonymInstances #-}
{-# LANGUAGE FlexibleInstances #-}

module Ordered where

class Ordered a where
  gt :: a -> a -> Bool 
  eq :: a -> a -> Bool 
  
instance Ordered Integer where
  gt r l = r > l
  eq r l = r == l
  
instance Ordered String where
  gt r l = r > l
  eq r l = r == l
  
instance (Ordered a, Ordered b) => Ordered (a, b) where
  gt (r1, r2) (l1, l2) = gt r1 l1 || (eq r1 l1 && gt r2 l2)
  eq (r1, r2) (l1, l2) = eq r1 l1 && eq r2 l2
  
