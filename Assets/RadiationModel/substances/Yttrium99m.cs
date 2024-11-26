using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium99m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium99m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 98.92646d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium99()), new(0.026099999999999998d, new GammaParticle(27700.0, 0.04476)), new(0.87d, new GammaParticle(125100.0, 0.00991)), new(0.5481d, new GammaParticle(158700.0, 0.00781)), new(0.3741d, new GammaParticle(198500.0, 0.00625)), new(0.435d, new GammaParticle(214000.0, 0.00579)), new(0.3132d, new GammaParticle(223900.0, 0.00554)), new(0.1131d, new GammaParticle(245200.0, 0.00506)), new(0.1653d, new GammaParticle(269600.0, 0.0046)), new(0.3306d, new GammaParticle(272900.0, 0.00454)), new(0.12179999999999999d, new GammaParticle(283500.0, 0.00437)), new(0.0435d, new GammaParticle(283800.0, 0.00437)), new(0.0348d, new GammaParticle(336300.0, 0.00369)), new(0.0783d, new GammaParticle(357200.0, 0.00347)), new(0.1131d, new GammaParticle(422300.0, 0.00294)), new(0.0348d, new GammaParticle(459200.0, 0.0027)), new(0.087d, new GammaParticle(493500.0, 0.00251)), new(0.060899999999999996d, new GammaParticle(496900.0, 0.0025)), new(0.0696d, new GammaParticle(546200.0, 0.00227)), new(0.0696d, new GammaParticle(553200.0, 0.00224)), new(0.0348d, new GammaParticle(619700.0, 0.002)), new(0.1653d, new GammaParticle(882500.0, 0.0014)), new(0.052199999999999996d, new GammaParticle(938800.0, 0.00132)), new(0.1392d, new GammaParticle(1166000.0, 0.00106)), new(0.1305d, new GammaParticle(1371000.0, 0.0009)), new(0.1305d, new GammaParticle(1435500.0, 0.00086)), new(0.3045d, new GammaParticle(1529500.0, 0.00081)), new(0.0116511059485752d, new GammaParticle(2027.0, 0.61166)), new(0.06946017150916672d, new GammaParticle(14883.0, 0.08331)), new(0.13319304220357953d, new GammaParticle(14958.0, 0.08289)), new(0.03344312261445848d, new GammaParticle(16803.0, 0.07379)), new(0.03805827353525375d, new GammaParticle(16880.0, 0.07345)), new(0.004615150920795271d, new GammaParticle(17011.0, 0.07288)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    