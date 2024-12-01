using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin115n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin115n";
        public override double halfLife { get; } = 0.00016d;
        public override double atomicWeight { get; } = 114.90411d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin115()), new(0.1484d, new GammaParticle(100700.0, 0.01231)), new(0.53d, new GammaParticle(115900.0, 0.0107)), new(0.848d, new GammaParticle(497600.0, 0.00249)), new(0.08940743812864d, new GammaParticle(3753.0, 0.33036)), new(0.2578905037497626d, new GammaParticle(25044.0, 0.04951)), new(0.48266985541786d, new GammaParticle(25271.0, 0.04906)), new(0.13648088156422516d, new GammaParticle(28579.0, 0.04338)), new(0.16336761523237756d, new GammaParticle(28810.0, 0.04304)), new(0.02688673366815236d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    