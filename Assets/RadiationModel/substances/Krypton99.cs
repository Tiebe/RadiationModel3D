using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton99 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton99";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 98.95878d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium99() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium99() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    