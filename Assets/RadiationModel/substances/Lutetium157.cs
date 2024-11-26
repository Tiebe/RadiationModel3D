using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium157";
        public override double halfLife { get; } = 6.8d;
        public override double atomicWeight { get; } = 156.95014d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium153() }, { 1.0d, new AlphaParticle(6130002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    