using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine108 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine108";
        public override double halfLife { get; } = 0.036d;
        public override double atomicWeight { get; } = 107.94335d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.91d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony104() }, { 1.0d, new AlphaParticle(5127002.09) } } },
            { 0.09d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony108() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium107() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    