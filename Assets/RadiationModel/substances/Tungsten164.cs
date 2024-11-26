using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten164 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten164";
        public override double halfLife { get; } = 6.3d;
        public override double atomicWeight { get; } = 163.95895d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9620000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium164() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.038d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium160() }, { 1.0d, new AlphaParticle(6300002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    