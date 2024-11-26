using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium169";
        public override double halfLife { get; } = 8.1d;
        public override double atomicWeight { get; } = 168.95877d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum169() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.0001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum165() }, { 1.0d, new AlphaParticle(6036002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    