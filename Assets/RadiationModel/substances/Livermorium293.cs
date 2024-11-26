using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Livermorium293 : RadioactiveSubstance
    {
        public override string name { get; } = "Livermorium293";
        public override double halfLife { get; } = 0.095d;
        public override double atomicWeight { get; } = 293.20459d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Flerovium289() }, { 1.0d, new AlphaParticle(11697002.09) } } },
            { 0.125d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    