using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium209";
        public override double halfLife { get; } = 50.5d;
        public override double atomicWeight { get; } = 208.99594d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine205() }, { 1.0d, new AlphaParticle(7800002.09) } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine209() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    