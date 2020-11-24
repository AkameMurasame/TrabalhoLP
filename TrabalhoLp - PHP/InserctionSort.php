<?php
function insertionSort($arr) {
    $j;
   $arrkey;
    $i;

    for ($j = 1; $j < count($arr); $j++)
    {
      $arrkey = $arr[$j];
      for ($i = $j - 1; ($i >= 0) && ($arr[$i] > $arrkey); $i--)
      {
         $arr[$i + 1] = $arr[$i];
       }
        $arr[$i + 1] = $arrkey;
    }
}

?>