using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium150m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium150m";
        public override double halfLife { get; } = 348.0d;
        public override double atomicWeight { get; } = 149.92416d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium150()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.004965d, new GammaParticle(95500.0, 0.01298)), new(0.00993d, new GammaParticle(154100.0, 0.00805)), new(0.072489d, new GammaParticle(162000.0, 0.00765)), new(0.013902000000000001d, new GammaParticle(179400.0, 0.00691)), new(0.013902000000000001d, new GammaParticle(180900.0, 0.00685)), new(0.004965d, new GammaParticle(235900.0, 0.00526)), new(0.018867000000000002d, new GammaParticle(274900.0, 0.00451)), new(0.24825d, new GammaParticle(343070.0, 0.00361)), new(0.09731400000000001d, new GammaParticle(412400.0, 0.00301)), new(0.03972d, new GammaParticle(415300.0, 0.00299)), new(0.41706000000000004d, new GammaParticle(438370.0, 0.00283)), new(0.11916d, new GammaParticle(455700.0, 0.00272)), new(0.233355d, new GammaParticle(496300.0, 0.0025)), new(0.24825d, new GammaParticle(510000.0, 0.00243)), new(0.21846d, new GammaParticle(566520.0, 0.00219)), new(0.993d, new GammaParticle(638050.0, 0.00194)), new(0.183705d, new GammaParticle(648400.0, 0.00191)), new(0.6951d, new GammaParticle(650400.0, 0.00191)), new(0.022839d, new GammaParticle(789900.0, 0.00157)), new(0.40713d, new GammaParticle(827480.0, 0.0015)), new(0.223d, new GammaParticle(511000.0, 0.00243)), new(0.11547982053255999d, new GammaParticle(6858.0, 0.18079)), new(0.17381232808890776d, new GammaParticle(42308.0, 0.02931)), new(0.3126683361915952d, new GammaParticle(42996.0, 0.02884)), new(0.09883684754899216d, new GammaParticle(48802.0, 0.02541)), new(0.12483093845437708d, new GammaParticle(49326.0, 0.02514)), new(0.025994090905384938d, new GammaParticle(49957.0, 0.02482)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    