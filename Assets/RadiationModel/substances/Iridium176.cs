using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium176 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium176";
        public override double halfLife { get; } = 8.7d;
        public override double atomicWeight { get; } = 175.96363d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9690000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium176() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.031d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium172() }, { 1.0d, new AlphaParticle(6285002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    