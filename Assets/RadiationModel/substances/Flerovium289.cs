using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium289 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium289";
        public override double halfLife { get; } = 2.4d;
        public override double atomicWeight { get; } = 289.19052d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copernicium285() }, { 1.0d, new AlphaParticle(10977002.09) } } },
            { 0.06d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    