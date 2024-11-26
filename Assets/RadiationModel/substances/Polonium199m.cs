using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium199m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium199m";
        public override double halfLife { get; } = 250.2d;
        public override double atomicWeight { get; } = 198.98398d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.735d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead199()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.24d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead195()), new(1.0d, new AlphaParticle(7408002.09)) } },
            { 0.025d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium199()), new(0.0013d, new GammaParticle(72000.0, 0.01722)), new(0.00037d, new GammaParticle(238000.0, 0.00521)), new(0.007261075471d, new GammaParticle(13292.0, 0.09328)), new(0.0023302537123977927d, new GammaParticle(76862.0, 0.01613)), new(0.0038805224186474487d, new GammaParticle(79290.0, 0.01564)), new(0.0013359564217808985d, new GammaParticle(89837.0, 0.0138)), new(0.001751438868954758d, new GammaParticle(90941.0, 0.01363)), new(0.00041548244717385947d, new GammaParticle(92315.0, 0.01343)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    