using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel76 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel76";
        public override double halfLife { get; } = 0.2347d;
        public override double atomicWeight { get; } = 75.95471d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper76() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper76() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    