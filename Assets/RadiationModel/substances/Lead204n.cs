using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead204n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead204n";
        public override double halfLife { get; } = 4015.8d;
        public override double atomicWeight { get; } = 203.97539d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead204()), new(0.0025d, new GammaParticle(289300.0, 0.00429)), new(0.9420000000000001d, new GammaParticle(374760.0, 0.00331)), new(0.0022d, new GammaParticle(622200.0, 0.00199)), new(2.2000000000000003e-05d, new GammaParticle(663430.0, 0.00187)), new(0.9917400000000001d, new GammaParticle(899150.0, 0.00138)), new(0.915d, new GammaParticle(911740.0, 0.00136)), new(0.00012d, new GammaParticle(1274000.0, 0.00097)), new(0.0463672494136693d, new GammaParticle(12522.0, 0.09901)), new(0.026469870296104422d, new GammaParticle(72805.0, 0.01703)), new(0.04448717696824273d, new GammaParticle(74970.0, 0.01654)), new(0.015205081556645818d, new GammaParticle(84986.0, 0.01459)), new(0.019797016186752857d, new GammaParticle(86022.0, 0.01441)), new(0.0045919346301070375d, new GammaParticle(87301.0, 0.0142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    