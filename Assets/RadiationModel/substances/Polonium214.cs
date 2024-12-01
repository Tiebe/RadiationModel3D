using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium214";
        public override double halfLife { get; } = 0.00016d;
        public override double atomicWeight { get; } = 213.9952d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead210()), new(1.0d, new AlphaParticle(8855402.09)), new(5.22e-07d, new GammaParticle(298000.0, 0.00416)), new(0.00010352999999999999d, new GammaParticle(799700.0, 0.00155)), new(3.4476351507930004e-07d, new GammaParticle(12522.0, 0.09901)), new(2.449251241808231e-07d, new GammaParticle(72805.0, 0.01703)), new(4.116388641694506e-07d, new GammaParticle(74970.0, 0.01654)), new(1.4069228321791576e-07d, new GammaParticle(84986.0, 0.01459)), new(1.8318135274972634e-07d, new GammaParticle(86022.0, 0.01441)), new(4.248906953181056e-08d, new GammaParticle(87301.0, 0.0142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    