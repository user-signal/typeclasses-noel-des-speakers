module Main where

import Test.Hspec
import Algorithm

main :: IO ()
main = hspec $ do
  describe "Ordered" $ do
    it "IntOrd" $
      (equality (sort [1, -4, 42, 12]::[Integer]) [-4, 1, 12, 42]) `shouldBe` True 

    it "StringOrd" $
      (equality (sort ["a", "z", "e", "r"]::[String]) ["a", "e", "r", "z"]) `shouldBe` True

    it "PairOrd" $
      (equality (sort [(1, "a"), (-4, "z"), (-4, "e"), (42, "r")]::[(Integer, String)]) [(-4,"e"), (-4,"z"), (1,"a"), (42,"r")]) `shouldBe` True
