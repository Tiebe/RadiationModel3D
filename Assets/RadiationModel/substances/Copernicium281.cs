using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium281 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium281";
        public override double halfLife { get; } = 0.18d;
        public override double atomicWeight { get; } = 281.16957d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Darmstadtium277() }, { 1.0d, new AlphaParticle(11457002.09) } } },
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
    