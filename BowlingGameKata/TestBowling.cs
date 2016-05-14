using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    [TestFixture]
    public class TestBowling
    {
        [Test]
        public void AllZero()
        {
            List<List<int>> pins = new List<List<int>>(10);
            pins.Add(new List<int> { 0, 0 });
            pins.Add(new List<int> { 0, 0 });
            pins.Add(new List<int> { 0, 0 });
            pins.Add(new List<int> { 0, 0 });
            pins.Add(new List<int> { 0, 0 });
            pins.Add(new List<int> { 0, 0 });
            pins.Add(new List<int> { 0, 0 });
            pins.Add(new List<int> { 0, 0 });
            pins.Add(new List<int> { 0, 0 });
            pins.Add(new List<int> { 0, 0 });

            Assert.That(Game.GetScore(pins), Is.EqualTo(0));
        }

        [Test]
        public void AllOnes()
        {
            List<List<int>> pins = new List<List<int>>(10);
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });

            Assert.That(Game.GetScore(pins), Is.EqualTo((1+1)*10));
        }

        [Test]
        public void OneStrike()
        {
            List<List<int>> pins = new List<List<int>>(10);
            pins.Add(new List<int> { 10 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });

            Assert.That(Game.GetScore(pins), Is.EqualTo(
                (10 + 1 + 1) + (1 + 1)* 9));
        }

        [Test]
        public void OneSpare()
        {
            List<List<int>> pins = new List<List<int>>(10);
            pins.Add(new List<int> { 5, 5 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });
            pins.Add(new List<int> { 1, 1 });

            Assert.That(Game.GetScore(pins), Is.EqualTo(
                (5+5+1) + (1 + 1) * 9));
        }

        [Test]
        public void allStrike()
        {
            List<List<int>> pins = new List<List<int>>(10);
            pins.Add(new List<int> {10 });
            pins.Add(new List<int> {10 });
            pins.Add(new List<int> {10 });
            pins.Add(new List<int> {10 });
            pins.Add(new List<int> {10 });
            pins.Add(new List<int> {10 });
            pins.Add(new List<int> {10 });
            pins.Add(new List<int> {10 });
            pins.Add(new List<int> {10 });
            pins.Add(new List<int> {10, 10, 10 });


            Assert.That(Game.GetScore(pins), Is.EqualTo(
                300));
        }

    }
}
