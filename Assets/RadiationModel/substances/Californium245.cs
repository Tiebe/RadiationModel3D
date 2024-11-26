using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium245";
        public override double halfLife { get; } = 2700.0d;
        public override double atomicWeight { get; } = 245.06805d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.649d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium245() } } },
            { 0.35100000000000003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium241() }, { 1.0d, new AlphaParticle(8280402.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    