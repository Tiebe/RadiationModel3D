using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium125m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium125m";
        public override double halfLife { get; } = 12.2d;
        public override double atomicWeight { get; } = 124.91405d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin125()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.52d, new GammaParticle(187630.0, 0.00661)), new(0.0046460752d, new GammaParticle(3753.0, 0.33036)), new(0.014034469581361285d, new GammaParticle(25044.0, 0.04951)), new(0.026267021488604315d, new GammaParticle(25271.0, 0.04906)), new(0.0074273257560855555d, new GammaParticle(28579.0, 0.04338)), new(0.00889050893003441d, new GammaParticle(28810.0, 0.04304)), new(0.0014631831739488543d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    