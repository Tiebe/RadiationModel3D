using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium174";
        public override double halfLife { get; } = 44.0d;
        public override double atomicWeight { get; } = 173.95706d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium174() } } },
            { 0.0002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten170() }, { 1.0d, new AlphaParticle(5893002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    