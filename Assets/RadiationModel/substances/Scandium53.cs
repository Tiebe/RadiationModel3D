using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium53 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium53";
        public override double halfLife { get; } = 2.6d;
        public override double atomicWeight { get; } = 52.95838d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium53() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    