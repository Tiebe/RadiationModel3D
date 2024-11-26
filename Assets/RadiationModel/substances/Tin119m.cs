using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin119m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin119m";
        public override double halfLife { get; } = 25323840.0d;
        public override double atomicWeight { get; } = 118.90341d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin119()), new(0.165d, new GammaParticle(23875.0, 0.05193)), new(0.0002d, new GammaParticle(65660.0, 0.01888)), new(0.111261368d, new GammaParticle(3753.0, 0.33036)), new(0.07925058871992471d, new GammaParticle(25044.0, 0.04951)), new(0.14832601295138448d, new GammaParticle(25271.0, 0.04906)), new(0.04194101781845514d, new GammaParticle(28579.0, 0.04338)), new(0.050203398328690814d, new GammaParticle(28810.0, 0.04304)), new(0.008262380510235662d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    