using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium197m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium197m";
        public override double halfLife { get; } = 32.0d;
        public override double atomicWeight { get; } = 196.98583d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.84d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead193() }, { 1.0d, new AlphaParticle(7629002.09) } } },
            { 0.16d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead197() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.0001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium197() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    