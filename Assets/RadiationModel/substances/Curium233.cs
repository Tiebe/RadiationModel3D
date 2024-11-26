using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium233";
        public override double halfLife { get; } = 23.0d;
        public override double atomicWeight { get; } = 233.05077d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium233() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium229() }, { 1.0d, new AlphaParticle(8497002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    