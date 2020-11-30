module Main where

import Test.Hspec
import Algorithm

main :: IO ()
main = hspec $ do
  describe "Ordered" $ do
    it "IntOrd" $
      (sort [1, -4, 42, 12]::[Integer]) `shouldBe` [-4,1,12,42]

    it "StringOrd" $
      (sort ["a", "z", "e", "r"]::[String]) `shouldBe` ["a","e","r","z"]

    it "PairOrd" $
      (sort [(1, "a"), (-4, "z"), (-4, "e"), (42, "r")]::[(Integer, String)]) `shouldBe`  [(-4,"e"),(-4,"z"),(1,"a"),(42,"r")]
