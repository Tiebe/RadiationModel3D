using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium178m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium178m";
        public override double halfLife { get; } = 4.0d;
        public override double atomicWeight { get; } = 177.94494d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium178()), new(0.643644d, new GammaParticle(88862.0, 0.01395)), new(0.17220300000000002d, new GammaParticle(93185.0, 0.01331)), new(0.813965d, new GammaParticle(213434.0, 0.00581)), new(0.941d, new GammaParticle(325557.0, 0.00381)), new(0.970171d, new GammaParticle(426360.0, 0.00291)), new(0.00015056d, new GammaParticle(515200.0, 0.00241)), new(0.28647590142618723d, new GammaParticle(9114.0, 0.13604)), new(0.16918530257379444d, new GammaParticle(54608.0, 0.0227)), new(0.2960890839583382d, new GammaParticle(55786.0, 0.02222)), new(0.09768191540453616d, new GammaParticle(63333.0, 0.01958)), new(0.1237629868175473d, new GammaParticle(64057.0, 0.01936)), new(0.026081071413011157d, new GammaParticle(64935.0, 0.01909)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    