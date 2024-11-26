using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium208";
        public override double halfLife { get; } = 0.095d;
        public override double atomicWeight { get; } = 208.01155d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium204() }, { 1.0d, new AlphaParticle(8750002.09) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium208() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    