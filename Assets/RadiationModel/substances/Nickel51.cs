using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel51 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel51";
        public override double halfLife { get; } = 0.0238d;
        public override double atomicWeight { get; } = 50.98749d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron51() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.872d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron50() }, { 1.0d, new ProtonParticle() }, { 0.73d, new GammaParticle(765300.0, 0.00162) }, { 0.29d, new GammaParticle(1086600.0, 0.00114) }, { 0.042d, new GammaParticle(1545700.0, 0.0008) }, { 0.044000000000000004d, new GammaParticle(1743400.0, 0.00071) } } },
            { 0.005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese49() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    