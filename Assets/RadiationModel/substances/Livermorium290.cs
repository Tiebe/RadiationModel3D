using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Livermorium290 : RadioactiveSubstance
    {
        public override string name { get; } = "Livermorium290";
        public override double halfLife { get; } = 0.0083d;
        public override double atomicWeight { get; } = 290.19864d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Flerovium286() }, { 1.0d, new AlphaParticle(12017002.09) } } },
            { 0.08d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    