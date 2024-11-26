using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium166";
        public override double halfLife { get; } = 0.213d;
        public override double atomicWeight { get; } = 165.9727d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.72d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten162() }, { 1.0d, new AlphaParticle(7164002.09) } } },
            { 0.28d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten166() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    